using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsmqTransactionProcessor.Data;
using MsmqTransactionProcessor.Models;

namespace MsmqTransactionProcessor.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly TransactionDbContext _context;

        public TransactionRepository(TransactionDbContext context)
        {
            _context = context;
        }

        public async Task AddTransactionAsync(TransactionMessage transactionMessage)
        {
            try
            {
                _context.Transactions.Add(transactionMessage);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Helpers.Logger.Log($"[DB ERROR] Failed to insert transaction: {ex.Message}");
                throw;
            }
        }
    }
}
