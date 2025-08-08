using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class Incident
    {
        public Incident()
        {
            LaneIncidents = new HashSet<LaneIncident>();
        }

        public int IncidentId { get; set; }
        public string IncidentCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LaneIncident> LaneIncidents { get; set; }
    }
}
