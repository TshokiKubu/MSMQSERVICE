using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{ 
    public partial class TransactionMissingDetail
    {
        public long TransactionNumber { get; set; }
        public byte LaneId { get; set; }
        public bool Received { get; set; }
        public DateTime? ReceivedAt { get; set; }
    }
}
