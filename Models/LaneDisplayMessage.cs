using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class LaneDisplayMessage
    {
        public int LaneDisplayMessageId { get; set; }
        public string English { get; set; }
        public string ToDisplay { get; set; }
    }
}
