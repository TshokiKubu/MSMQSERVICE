using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Denominations = new HashSet<Denomination>();
            ExchangeRateFromCurrencies = new HashSet<ExchangeRate>();
            ExchangeRateToCurrencies = new HashSet<ExchangeRate>();
            TariffPlans = new HashSet<TariffPlan>();
            Transactions = new HashSet<Transaction>();
        }

        public byte CurrencyId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }

        public virtual ICollection<Denomination> Denominations { get; set; }
        public virtual ICollection<ExchangeRate> ExchangeRateFromCurrencies { get; set; }
        public virtual ICollection<ExchangeRate> ExchangeRateToCurrencies { get; set; }
        public virtual ICollection<TariffPlan> TariffPlans { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
