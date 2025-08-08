using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class LaneIncident
    {
        public long LaneIncidentId { get; set; }
        public int IncidentId { get; set; }
        public DateTime OccurredAt { get; set; }
        public long? TransactionNumber { get; set; }

        public virtual Incident Incident { get; set; }
    }
}
