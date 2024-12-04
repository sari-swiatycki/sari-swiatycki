using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.Entities
{
    [Table("Shipment")]

    public class Shipment
    {
        [Key]
        public int ShipmentID { get; set; }
        public int SenderID { get; set; }
        public int CourierID { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public string Status { get; set; }
        public string PickupDateTime { get; set; }
    }
}
