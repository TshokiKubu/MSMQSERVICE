using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class LaneLastTransactionImage
    {
        public byte LaneId { get; set; }
        public long LastLaneTransactionImageId { get; set; }

        public virtual Lane Lane { get; set; }
    }
}
