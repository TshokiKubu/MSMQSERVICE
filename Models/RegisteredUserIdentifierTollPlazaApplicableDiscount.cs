using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class RegisteredUserIdentifierTollPlazaApplicableDiscount
    {
        public long RegisteredUserIdentifierId { get; set; }
        public byte TollPlazaId { get; set; }
        public double CurrentDiscountPercentage { get; set; }
        public double CurrentDiscountAmount { get; set; }

        public virtual RegisteredUserIdentifier RegisteredUserIdentifier { get; set; }
        public virtual TollPlaza TollPlaza { get; set; }
    }
}
