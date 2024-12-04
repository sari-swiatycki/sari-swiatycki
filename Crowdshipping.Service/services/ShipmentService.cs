using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IRepository;
using ClassLibrary1.core.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdshipping.Service.services
{
    public class ShipmentService: IShipmentService
    {
        readonly IGenericRepository<Shipment> _shipmentRepository;
        public ShipmentService(IGenericRepository<Shipment> sr)
        {
            _shipmentRepository = sr;
        }
        public List<Shipment> GetShipmentList()
        {
            return _shipmentRepository.GetAllData() ;
        }
        public Shipment GetByIdShipmentService(int id)
        {
            return _shipmentRepository.GetById(id);
                
        }

        public bool PostShipmentList(Shipment ship)
        {

            return _shipmentRepository.AddData(ship);

        }
        public bool PutShipmentsList(int shipmentID,Shipment ship)
        {
           return _shipmentRepository.UpdateData(shipmentID,ship);

        }
        public bool DeleteShipmentList(int id)
        {

           return _shipmentRepository.DeleteData(id);
        }
   

    }
}
