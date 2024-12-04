using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdshipping.Data.Repository
{
    public class PackageOrdererRepository:IGenericRepository<PackageOrderer>
    {

        readonly DataContext _dataContext;
        public PackageOrdererRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<PackageOrderer> GetAllData()
        {

            var data = _dataContext.packageOrdererList.ToList();
            if (data == null)
                return null;
            return data;


        }


        public PackageOrderer GetById(int id)
        {

            var data = _dataContext.packageOrdererList;
            if (data == null)
                return null;
            return data.Where(c => c.OrdererID == id).FirstOrDefault();

        }





        public bool AddData(PackageOrderer po)
        {

            try
            {

                _dataContext.packageOrdererList.Add(po);
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
            var data = _dataContext.packageOrdererList.ToList();
            if (data == null) return false;
            int index = data.FindIndex(x => x.OrdererID == id);
            if (index != -1)
            {
                data.Remove(data.Find(x => x.OrdererID == id));
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }
        //public bool UpdateData(int id, PackageOrderer couier)
        //{
        //    var data = _dataContext.packageOrdererList;
        //    if (data == null) return false;
        //    int index = data.FindIndex(x => x.OrdererID == id);
        //    if (index != -1)
        //    {
        //        data.RemoveAt(index);
        //        data.Insert(index, couier);
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}




        public bool UpdateData(int id, PackageOrderer updatedOrderer)
        {
            var orderer = _dataContext.packageOrdererList.FirstOrDefault(x => x.OrdererID == id);
            if (orderer == null) return false;

            if (!string.IsNullOrEmpty(updatedOrderer.FullName))
                orderer.FullName = updatedOrderer.FullName;

            if (!string.IsNullOrEmpty(updatedOrderer.ContactPhone))
                orderer.ContactPhone = updatedOrderer.ContactPhone;

            if (!string.IsNullOrEmpty(updatedOrderer.Email))
                orderer.Email = updatedOrderer.Email;

            if (!string.IsNullOrEmpty(updatedOrderer.HomeAddress))
                orderer.HomeAddress = updatedOrderer.HomeAddress;

            if (!string.IsNullOrEmpty(updatedOrderer.DeliveryPreferences))
                orderer.DeliveryPreferences = updatedOrderer.DeliveryPreferences;

            if (!string.IsNullOrEmpty(updatedOrderer.Status))
                orderer.Status = updatedOrderer.Status;

            _dataContext.SaveChanges();
            return true;
        }
    }
}
