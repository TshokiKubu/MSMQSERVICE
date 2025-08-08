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
    public class Program
    {
        static async Task Main(string[] args)
        {
           
            var host = CreateHostBuilder(args).Build();

            bool sendTestMessages = false;

            if (sendTestMessages)
            {
               var repository = host.Services.GetRequiredService<ITransactionRepository>();             
            }
            else
            {
                var processor = host.Services.GetRequiredService<MsmqListener>();

                // Note: this is no longer async, just start listener
                processor.StartListening();

                // Keep app running indefinitely so listener stays alive
                await Task.Delay(-1);
            }
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("SQLServerConnection");

                services.AddDbContext<TransactionDbContext>(options =>
                    options.UseSqlServer(connectionString)
                    .EnableSensitiveDataLogging());
       
        services.AddScoped<ITransactionRepository, TransactionRepository>();
                    services.AddTransient<MsmqListener>();
                });
    }
}