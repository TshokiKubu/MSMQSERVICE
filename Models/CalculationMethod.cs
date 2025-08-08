using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class CalculationMethod
    {
        public CalculationMethod()
        {
            DiscountTypes = new HashSet<DiscountType>();
        }

        public byte CalculationMethodId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DiscountType> DiscountTypes { get; set; }
    }
}
