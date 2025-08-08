using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class DiscountStructureDetail
    {
        public int DiscountStructureDetailId { get; set; }
        public int DiscountStructureId { get; set; }
        public byte TollClassId { get; set; }
        public double? Percentage { get; set; }
        public byte? MininumTrips { get; set; }
        public byte? MaxTrips { get; set; }
        public double? DiscountAmount { get; set; }
        public bool? CarryOverToNextMonth { get; set; }
        public double? CappAmount { get; set; }

        public virtual DiscountStructure DiscountStructure { get; set; }
        public virtual TollClass TollClass { get; set; }
    }
}
