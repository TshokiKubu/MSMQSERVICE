using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class ControlCentre
    {
        public ControlCentre() => TollPlazas = new HashSet<TollPlaza>();

        public byte ControlCentreId { get; set; }
        public string ControlCentreName { get; set; }
        public string ControlCentreCode { get; set; }

        public virtual ICollection<TollPlaza> TollPlazas { get; set; }
    }
}
