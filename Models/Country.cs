using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class Country
    {
        public Country()
        {
            RegisteredUserAddresses = new HashSet<RegisteredUserAddress>();
        }

        public int CountryId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RegisteredUserAddress> RegisteredUserAddresses { get; set; }
    }
}
