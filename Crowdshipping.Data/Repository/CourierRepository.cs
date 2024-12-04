using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdshipping.Data.Repository
{
    public class CourierRepository:IGenericRepository<Courier>
    {
        readonly DataContext _dataContext;
        public CourierRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Courier> GetAllData()
        {

            var data = _dataContext.CouriersList;
            if (data == null)
                return null;
            return data.ToList();


        }


        public Courier GetById(int id)
        {

            var data = _dataContext.CouriersList;
            if (data == null)
                return null;
            return data.ToList().Where(c => c.CourierID == id).FirstOrDefault();

        }






        public bool AddData(Courier cou)
        {
            try
            {

                _dataContext.CouriersList.ToList().Add(cou);
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
            var data = _dataContext.CouriersList.ToList();
            if (data == null) return false;
            int index = data.FindIndex(x => x.CourierID == id);
            if (index != -1)
            {
                data.Remove(data.Find(x => x.CourierID == id));
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }

        //public bool UpdateData(int id, Courier couier)
        //{
        //    var data = _dataContext.CouriersList;
        //    if (data == null) return false;
        //    int index = data.FindIndex(x => x.CourierID == id);
        //    if (index != -1)
        //    {


        //        data.RemoveAt(index);
        //        data.Insert(index, couier);
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}


        public bool UpdateData(int id, Courier updatedCourier)
        {
            var existingCourier = _dataContext.CouriersList.ToList(). FirstOrDefault(x => x.CourierID == id);
            if (existingCourier == null) return false;

            // עדכון רק שדות שאינם null או ערכי ברירת מחדל
            if (updatedCourier.UserID != 0)
                existingCourier.UserID = updatedCourier.UserID;

            if (!string.IsNullOrEmpty(updatedCourier.FullName))
                existingCourier.FullName = updatedCourier.FullName;

            if (updatedCourier.VehicleID != 0)
                existingCourier.VehicleID = updatedCourier.VehicleID;

            if (updatedCourier.Rating != 0)
                existingCourier.Rating = updatedCourier.Rating;

            if (!string.IsNullOrEmpty(updatedCourier.ContactPhone))
                existingCourier.ContactPhone = updatedCourier.ContactPhone;

            // Boolean אינו מקבל null ולכן נבדוק את הערך עצמו
            existingCourier.Availability = updatedCourier.Availability;

            // שמירת שינויים
            _dataContext.SaveChanges();
            return true;
        }


    }
}



