using MsmqTransactionProcessor.Data;
using MsmqTransactionProcessor.Models;
using MsmqTransactionProcessor.Repositories;
using MsmqTransactionProcessor.Services;
using System;


using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;



namespace MsmqTransactionProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // Run your MSMQ service logic
            var processor = host.Services.GetRequiredService<MsmqListener>();
            processor.StartListening();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                    services.AddDbContext<TransactionDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    services.AddTransient<ITransactionRepository, TransactionRepository>();
                    services.AddTransient<MsmqListener>();
                });
    }
}