using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class Camera
    {
        public Camera()
        {
            LaneCameras = new HashSet<LaneCamera>();
        }

        public byte CameraId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<LaneCamera> LaneCameras { get; set; }
    }
}
