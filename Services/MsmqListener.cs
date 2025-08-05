using Experimental.System.Messaging;
using MsmqTransactionProcessor.Models;
using MsmqTransactionProcessor.Repositories;
using Newtonsoft.Json;
using System;
//using System.Messaging;
using System.Threading.Tasks;


namespace MsmqTransactionProcessor.Services
{
    public class MsmqListener
    {
        private const string QueuePath = @".\Private$\TransactionQueue"; // To be adjusted
        private readonly ITransactionRepository _repository;

        public MsmqListener(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public void StartListening()
        {
            try
            {
                if (!MessageQueue.Exists(QueuePath))
                {
                    MessageQueue.Create(QueuePath);
                }

                using var queue = new MessageQueue(QueuePath)
                {
                    Formatter = new XmlMessageFormatter(new[] { typeof(string) })
                };

                Console.WriteLine("Listening to MSMQ... Press Ctrl+C to exit.");
                while (true)
                {
                    var message = queue.Receive(); // Blocking call
                    var jsonBody = message.Body.ToString();

                    Helpers.Logger.Log($"[INFO] Message received: {jsonBody}");

                    var transaction = JsonConvert.DeserializeObject<TransactionMessage>(jsonBody);
                    if (transaction != null)
                    {
                        Task.Run(() => _repository.AddTransactionAsync(transaction));
                    }
                    else
                    {
                        Helpers.Logger.Log("[WARN] Deserialized transaction is null");
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.Logger.Log($"[ERROR] MSMQ listener failed: {ex.Message}");
            }
        }
    }
}