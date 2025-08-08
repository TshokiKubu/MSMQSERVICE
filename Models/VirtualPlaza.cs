using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class VirtualPlaza
    {
        public VirtualPlaza()
        {
            Lanes = new HashSet<Lane>();
        }

        public byte VirtualPlazaId { get; set; }
        public string VirtualPlazaCode { get; set; }
        public string VirtualPlazaName { get; set; }
        public byte? TollPlazaId { get; set; }

        public virtual TollPlaza TollPlaza { get; set; }
        public virtual ICollection<Lane> Lanes { get; set; }
    }
}
