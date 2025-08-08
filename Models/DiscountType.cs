using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class DiscountType
    {
        public DiscountType()
        {
            DiscountStructures = new HashSet<DiscountStructure>();
            Transactions = new HashSet<Transaction>();
        }

        public byte DiscountTypeId { get; set; }
        public string Description { get; set; }
        public byte CalculationMethodId { get; set; }

        public virtual CalculationMethod CalculationMethod { get; set; }
        public virtual ICollection<DiscountStructure> DiscountStructures { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
