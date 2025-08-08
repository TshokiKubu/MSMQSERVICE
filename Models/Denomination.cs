using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class Denomination
    {
        public Denomination()
        {
            CollectorCashDeclarationDenominations = new HashSet<CollectorCashDeclarationDenomination>();
        }

        public int DenominationId { get; set; }
        public byte CurrencyId { get; set; }
        public string Description { get; set; }
        public double Mulitplier { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual ICollection<CollectorCashDeclarationDenomination> CollectorCashDeclarationDenominations { get; set; }
    }
}
