using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{ 
    public partial class Ufdmessage
    {
        public byte UfdmessageId { get; set; }
        public string Ufdmessage1 { get; set; }
        public string Page1Line1 { get; set; }
        public string Page1Line2 { get; set; }
        public string Page2Line1 { get; set; }
        public string Page2Line2 { get; set; }
    }
}
