using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class CollectorCashDeclarationForeignCurrency
    {
        public long CollectorCashDeclarationId { get; set; }
        public byte CurrencyId { get; set; }
        public double ForeignCurrencyReceived { get; set; }
        public double ExchangeRateUsed { get; set; }
        public double AmountInLocalCurrency { get; set; }
    }
}
