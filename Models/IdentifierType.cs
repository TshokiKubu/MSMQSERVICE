using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class IdentifierType
    {
        public IdentifierType()
        {
            RegisteredUserIdentifiers = new HashSet<RegisteredUserIdentifier>();
        }

        public byte IdentifierTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RegisteredUserIdentifier> RegisteredUserIdentifiers { get; set; }
    }
}
