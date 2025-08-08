using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            RegisteredUserTopUps = new HashSet<RegisteredUserTopUp>();
        }

        public byte PaymentMethodId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RegisteredUserTopUp> RegisteredUserTopUps { get; set; }
    }
}
