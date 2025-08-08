using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class CashupShortagePaymentMethod
    {
        public CashupShortagePaymentMethod()
        {
            CollectorCashupShortagePayments = new HashSet<CollectorCashupShortagePayment>();
        }

        public byte CashupShortagePaymentMethodId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CollectorCashupShortagePayment> CollectorCashupShortagePayments { get; set; }
    }
}
