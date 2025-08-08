using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class LaneCamera
    {
        public byte LaneId { get; set; }
        public byte CameraId { get; set; }
        public bool? DefaultCamera { get; set; }

        public virtual Camera Camera { get; set; }
        public virtual Lane Lane { get; set; }
    }
}
