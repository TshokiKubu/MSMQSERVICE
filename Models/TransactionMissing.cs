using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class TransactionMissing
    {
        public long TransactionMissing1 { get; set; }
        public byte LaneId { get; set; }
        public long StartTransactionNumber { get; set; }
        public long EndTransactionNumber { get; set; }
        public int NumberMissing { get; set; }
        public int NumberReceived { get; set; }
        public bool NoMoreMissing { get; set; }
    }
}
