using ClassLibrary1.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.IService
{
    public interface IShipmentService
    {
        List<Shipment> GetShipmentList();

        Shipment GetByIdShipmentService(int id);
        bool PostShipmentList(Shipment shipment);
        bool PutShipmentsList(int id,Shipment shipment);
        bool DeleteShipmentList(int id);
   
    }
}
