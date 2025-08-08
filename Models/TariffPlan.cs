using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class TariffPlan
    {
        public TariffPlan()
        {
            TariffPlanDetails = new HashSet<TariffPlanDetail>();
            Transactions = new HashSet<Transaction>();
        }

        public int TariffPlanId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public byte CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual ICollection<TariffPlanDetail> TariffPlanDetails { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
