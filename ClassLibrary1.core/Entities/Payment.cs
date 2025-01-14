using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.Entities
{
    [Table("Payment")]

    public class Payment
    { 
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
        public int PaymentMethod { get; set; }
        public int Amount { get; set; }
       
        [Key]
        public int PaymentID { get; set; }
        public int MyProperty { get; set; }
        public int ShipmentID { get; set; }

        [ForeignKey(nameof(ShipmentID))]
        public Shipment Shipment { get; set; }
    }
}
