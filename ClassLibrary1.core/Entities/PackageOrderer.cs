using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.Entities
{
    [Table("PackageOrderer")]
   public class PackageOrderer
    {
        [Key]
        public int OrdererID { get; set; }
        public string FullName { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string DeliveryPreferences { get; set; }
        public string Status { get; set; }
    }
}
