using ClassLibrary1.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdshipping.Data
{
    public class EntitiesLists
    {
        public List<Payment> PaymentsList { get; set; }
        public List<Shipment> shipmentsList { get; set; }
        public List<PackageOrderer> packageOrdererList { get; set; }
        public List<Courier> CouriersList { get; set; }

    }
}
