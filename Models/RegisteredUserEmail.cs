using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class RegisteredUserEmail
    {
        public long RegisteredUserId { get; set; }
        public byte EmailTypeId { get; set; }
        public string EmailAddress { get; set; }

        public virtual RegisteredUser RegisteredUser { get; set; }
    }
}
