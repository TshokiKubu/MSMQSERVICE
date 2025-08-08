using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{ 
    public partial class ExemptType
    {
        public ExemptType()
        {
            TransactionClassCorrections = new HashSet<TransactionClassCorrection>();
        }

        public byte ExemptTypeId { get; set; }
        public string ExemptTypeDescription { get; set; }
        public byte DisplayOrder { get; set; }

        public virtual ICollection<TransactionClassCorrection> TransactionClassCorrections { get; set; }
    }
}
