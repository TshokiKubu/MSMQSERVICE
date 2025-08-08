using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class DiscountStructure
    {
        public DiscountStructure()
        {
            DiscountStructureDetails = new HashSet<DiscountStructureDetail>();
        }

        public int DiscountStructureId { get; set; }
        public byte DiscountTypeId { get; set; }
        public DateTime EffectiveDate { get; set; }

        public virtual DiscountType DiscountType { get; set; }
        public virtual ICollection<DiscountStructureDetail> DiscountStructureDetails { get; set; }
    }
}
