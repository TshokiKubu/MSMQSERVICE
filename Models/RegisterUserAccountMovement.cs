using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class RegisterUserAccountMovement
    {
        public long RegisterUserAccountMovementId { get; set; }
        public long RegisterUserId { get; set; }
        public long? RegisteredUserTopUpId { get; set; }
        public long? RegisteredUserLaneTransactionId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string Description { get; set; }
        public double OpeningBalance { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double ClosingBalance { get; set; }

        public virtual RegisteredUser RegisterUser { get; set; }
        public virtual RegisteredUserTopUp RegisteredUserTopUp { get; set; }
    }
}
