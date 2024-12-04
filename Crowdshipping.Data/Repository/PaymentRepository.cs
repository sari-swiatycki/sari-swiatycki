using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdshipping.Data.Repository
{
    public class PaymentRepository : IGenericRepository<Payment>
    {

        readonly DataContext _dataContext;
        public PaymentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Payment> GetAllData()
        {

            var data = _dataContext.PaymentsList.ToList();
            if (data == null)
                return null;
            return data.ToList();


        }


        public Payment GetById(int id)
        {

            var data = _dataContext.PaymentsList.ToList();
            if (data == null)
                return null;
            return data.Where(c => c.PaymentID == id).FirstOrDefault();

        }





        public bool AddData(Payment cou)
        {
            try
            {

                _dataContext.PaymentsList.ToList().Add(cou);
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
            var data = _dataContext.PaymentsList.ToList();
            if (data == null) return false;
            int index = data. FindIndex(x => x.PaymentID == id);
            if (index != -1)
            {
                data.Remove(data.Find(x => x.PaymentID == id));
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
        //public bool UpdateData(int id, Payment pa)
        //{
        //    var data = _dataContext.PaymentsList;
        //    if (data == null) return false;
        //    int index = data.FindIndex(x => x.PaymentID == id);
        //    if (index != -1)
        //    {
        //        data.RemoveAt(index);
        //        data.Insert(index, pa);
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}



        public bool UpdateData(int id, Payment updatedPayment)
        {
            var existingPayment = _dataContext.PaymentsList.ToList().FirstOrDefault(x => x.PaymentID == id);
            if (existingPayment == null) return false;

            // עדכון רק שדות שאינם null או ערכים ברירת מחדל
            if (updatedPayment.PaymentDate != default(DateTime))
                existingPayment.PaymentDate = updatedPayment.PaymentDate;

            if (!string.IsNullOrEmpty(updatedPayment.Status))
                existingPayment.Status = updatedPayment.Status;

            if (updatedPayment.PaymentMethod != 0)
                existingPayment.PaymentMethod = updatedPayment.PaymentMethod;

            if (updatedPayment.Amount != 0)
                existingPayment.Amount = updatedPayment.Amount;

            if (updatedPayment.ShipmentID != 0)
                existingPayment.ShipmentID = updatedPayment.ShipmentID;

            // שמירת שינויים
            _dataContext.SaveChanges();
            return true;
        }

    }
}
