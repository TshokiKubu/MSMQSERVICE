using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class ExchangeRate
    {
        public byte FromCurrencyId { get; set; }
        public byte ToCurrencyId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public double RateOfExchange { get; set; }

        public virtual Currency FromCurrency { get; set; }
        public virtual Currency ToCurrency { get; set; }
    }
}
