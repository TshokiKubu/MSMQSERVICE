using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class Role
    {
        public Role()
        {
            SystemUserRoles = new HashSet<SystemUserRole>();
        }

        public short RoleId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SystemUserRole> SystemUserRoles { get; set; }
    }
}
