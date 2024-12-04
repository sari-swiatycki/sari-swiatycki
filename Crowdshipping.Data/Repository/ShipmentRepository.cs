using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace Crowdshipping.Data.Repository
{
    public class ShipmentRepository:IGenericRepository<Shipment>
    {
        readonly DataContext _dataContext;
        public ShipmentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Shipment> GetAllData()
        {

            var data = _dataContext.shipmentsList;
            if (data == null)
                return null;
            return data.ToList();


        }


        public Shipment GetById(int id)
        {

            var data = _dataContext.shipmentsList.ToList();
            if (data == null)
                return null;
            return data.Where(c => c.ShipmentID == id).FirstOrDefault();

        }





        public bool AddData(Shipment s)
        {
        


            try
            {

                _dataContext.shipmentsList.ToList().Add(s);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteData(int id)
        {
            var data = _dataContext.shipmentsList.ToList();
            if (data == null) return false;
            int index = data.ToList().FindIndex(x => x.ShipmentID == id);
            if (index != -1)
            {
                data.Remove(data.ToList()  .Find(x => x.ShipmentID == id));
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
        //public bool UpdateData(int id, Shipment pa)
        //{
        //    var data = _dataContext.shipmentsList;
        //    if (data == null) return false;
        //    int index = data.FindIndex(x => x.ShipmentID == id);
        //    if (index != -1)
        //    {
        //        data.RemoveAt(index);
        //        data.Insert(index, pa);
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}



        public bool UpdateData(int id, Shipment updatedShipment)
        {
            var existingShipment = _dataContext.shipmentsList.ToList().FirstOrDefault(x => x.ShipmentID == id);
            if (existingShipment == null) return false;

            // עדכון רק שדות שאינם null או ערכים ברירת מחדל
            if (updatedShipment.SenderID != 0)
                existingShipment.SenderID = updatedShipment.SenderID;

            if (updatedShipment.CourierID != 0)
                existingShipment.CourierID = updatedShipment.CourierID;

            if (!string.IsNullOrEmpty(updatedShipment.PickupLocation))
                existingShipment.PickupLocation = updatedShipment.PickupLocation;

            if (!string.IsNullOrEmpty(updatedShipment.DropoffLocation))
                existingShipment.DropoffLocation = updatedShipment.DropoffLocation;

            if (!string.IsNullOrEmpty(updatedShipment.Status))
                existingShipment.Status = updatedShipment.Status;

            if (!string.IsNullOrEmpty(updatedShipment.PickupDateTime))
                existingShipment.PickupDateTime = updatedShipment.PickupDateTime;

            // שמירת שינויים
            _dataContext.SaveChanges();
            return true;
        }

    }
}
