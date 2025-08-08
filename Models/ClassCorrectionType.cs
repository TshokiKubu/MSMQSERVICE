using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class ClassCorrectionType
    {
        public ClassCorrectionType()
        {
            TransactionClassCorrections = new HashSet<TransactionClassCorrection>();
        }

        public byte ClassCorrectionTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TransactionClassCorrection> TransactionClassCorrections { get; set; }
    }
}
