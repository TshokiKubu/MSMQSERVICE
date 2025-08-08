using Experimental.System.Messaging;
using MsmqTransactionProcessor.Repositories;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using MsmqTransactionProcessor.Models;


namespace MsmqTransactionProcessor.Services
{
    public class MsmqListener
    {
        private const string QueuePath = @".\Private$\transactions";
        private readonly ITransactionRepository _repository;
        private MessageQueue _queue;

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

                _queue = new MessageQueue(QueuePath)
                {
                    Formatter = new XmlMessageFormatter(new[] { typeof(string) })
                };

                _queue.ReceiveCompleted += OnMessageReceived;
                _queue.BeginReceive();

                Console.WriteLine("Listening to MSMQ... Press Ctrl+C to exit.");
            }
            catch (Exception ex)
            {
                Helpers.Logger.Log($"[ERROR] MSMQ listener failed to start: {ex.Message}");
            }
        }

        private async void OnMessageReceived(object sender, ReceiveCompletedEventArgs e)
        {
            try
            {
                var msg = _queue.EndReceive(e.AsyncResult);
                var jsonBody = msg.Body.ToString();

                Helpers.Logger.Log($"[INFO] Message received: {jsonBody}");

                var transaction = JsonConvert.DeserializeObject<Transaction>(jsonBody);
                if (transaction != null)
                {
                    await _repository.AddTransactionAsync(transaction);                     
                }
                else
                {
                    Helpers.Logger.Log("[WARN] Deserialized transaction is null");
                }
            }
            catch (Exception ex)
            {
                Helpers.Logger.Log($"[ERROR] Error processing message: {ex.Message}");
            }
            finally
            {
                // Continue listening for next message
                _queue.BeginReceive();
            }
        }
    }
}
