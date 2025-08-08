using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class CollectorCashupCashSurplusAllocatedToDiscrepancy
    {
        public CollectorCashupCashSurplusAllocatedToDiscrepancy()
        {
            CollectorCashupShortagePayments = new HashSet<CollectorCashupShortagePayment>();
        }

        public long CollectorCashupCashSurplusAllocatedToDiscrepancyId { get; set; }
        public long CollectorCashUpId { get; set; }
        public double AmountAllocated { get; set; }

        public virtual CollectorCashup CollectorCashUp { get; set; }
        public virtual ICollection<CollectorCashupShortagePayment> CollectorCashupShortagePayments { get; set; }
    }
}
