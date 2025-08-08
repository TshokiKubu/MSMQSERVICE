using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class TransactionImage
    {
        public long TransactionImageId { get; set; }
        public long LaneTransactionImageId { get; set; }
        public byte LaneId { get; set; }
        public long TransactionNumber { get; set; }
        public string SnapShot { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
