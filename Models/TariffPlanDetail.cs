using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class TariffPlanDetail
    {
        public int TariffPlanId { get; set; }
        public byte TollClassId { get; set; }
        public double AmountInclusive { get; set; }
        public double Vat { get; set; }
        public double DiscountAmount { get; set; }
        public double AmountExclusive { get; set; }
        public double VatRate { get; set; }

        public virtual TariffPlan TariffPlan { get; set; }
        public virtual TollClass TollClass { get; set; }
    }
}
