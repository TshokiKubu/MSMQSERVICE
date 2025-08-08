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

        public async Task AddTransactionAsync(Transaction transaction)
        {
            try
            {
                _context.Transactions.Add(transaction);
                var affected = await _context.SaveChangesAsync();
                Helpers.Logger.Log($"[DB INFO] SaveChanges returned: {affected}");
            }
            catch (Exception ex)
            {
                Helpers.Logger.Log($"[DB ERROR] Failed to insert transaction: {ex.Message}");
                throw;
            }
        }
    }
}
