using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{

    public partial class CollectorCashDeclarationDenomination
    {
        public long CollectorCashDeclarationId { get; set; }
        public int DenominationId { get; set; }
        public int NumberOf { get; set; }
        public double Amount { get; set; }

        public virtual CollectorCashDeclaration CollectorCashDeclaration { get; set; }
        public virtual Denomination Denomination { get; set; }
    }
}
