using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IRepository;
using ClassLibrary1.core.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Crowdshipping.Service.services
{
    public class CourierService:ICourierService
    {


        readonly IGenericRepository<Courier> _CourierService;
        public CourierService(IGenericRepository<Courier> cou)
        {
            _CourierService = cou;


        }
       



        public List<Courier> GetCouriersList()
        {
            return _CourierService.GetAllData();
        }
        public Courier GetByIdCourierList(int id)
        {
            return _CourierService.GetById(id);

        }

        public bool PostCouriersList(Courier co)
        {

            return _CourierService.AddData(co);

        }
        public bool PutCourierList(int poid, Courier po)
        {
            return _CourierService.UpdateData(poid, po);

        }
        public bool DeleteCourierList(int id)
        {

            return _CourierService.DeleteData(id);
        }
   
    }
}


