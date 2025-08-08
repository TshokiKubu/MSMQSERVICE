using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class LaneLastNo
    {
        public byte LaneId { get; set; }
        public long LastTransactionNo { get; set; }
        public long LastInvoiceNo { get; set; }
        public long LastReceiptNo { get; set; }
        public long LastLoginId { get; set; }

        public virtual Lane Lane { get; set; }
    }
}
