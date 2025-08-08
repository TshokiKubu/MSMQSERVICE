using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTransactionProcessor.Models
{
    public partial class Entity
    {
        public int EntityId { get; set; }
        public string EntityCode { get; set; }
        public string Apikey { get; set; }
        public string Description { get; set; }
    }
}
