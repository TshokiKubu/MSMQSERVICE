using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MsmqTransactionProcessor.Models;

namespace MsmqTransactionProcessor.Data
{
    public partial class TransactionDbContext : DbContext
    {
        public TransactionDbContext()
        {
        }

        public TransactionDbContext(DbContextOptions<TransactionDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TransactionMessage> Transactions { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionMessage>(entity =>
            {
                entity.HasKey(e => e.LaneId);

                entity.Property(e => e.TransactionNumber)
                    .HasColumnName("Id")
                    .ValueGeneratedOnAdd();
               

                // Add any additional mappings here based on your schema
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}