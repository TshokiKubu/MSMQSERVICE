using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class AllocatedTo
    {
        public AllocatedTo()
        {
            TransactionClassCorrections = new HashSet<TransactionClassCorrection>();
        }

        public byte AllocatedToId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TransactionClassCorrection> TransactionClassCorrections { get; set; }
    }
}
