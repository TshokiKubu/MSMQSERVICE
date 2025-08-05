using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public class TransactionMessage
    {
        public int LaneId { get; set; }
        public string TransactionNumber { get; set; }
        public int TransactionTypeId { get; set; }
        public int? DiscountTypeId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public int ShiftId { get; set; }
        public DateTime ShiftDate { get; set; }
        public int SystemUserId { get; set; }
        public int? ManualTollClassId { get; set; }
        public int? TariffPlanId { get; set; }
        public int CurrencyId { get; set; }
        public decimal NominalTariff { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal NettAmount { get; set; }
        public decimal VatAmout { get; set; }
        public string InvoiceReceiptPrefix { get; set; }
        public string InvoiceNo { get; set; }
        public string ReceiptNo { get; set; }
        public int? AutomaticTollClassId { get; set; }
        public decimal? AutomaticAmount { get; set; }
        public decimal? ForeignCurrencyReceived { get; set; }
        public decimal? ExchangeRateUsed { get; set; }
        public decimal? ChangeInLocalCurrency { get; set; }
        public int? RegisteredUserId { get; set; }
        public string RegisteredIdentifier { get; set; }
        public int? RegisteredTollClassId { get; set; }
        public string CardNumber { get; set; }
        public int? ActualTollClassId { get; set; }
        public decimal? ActualAmount { get; set; }
        public byte[] RowVersion { get; set; }
        public int? AllocatedToCollectorCashupId { get; set; }
    }
}
