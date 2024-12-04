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
  public class PackageOrdererService:IPackageOrdererService
    {


        readonly IGenericRepository<PackageOrderer> _PackageOrderer;
        public PackageOrdererService(IGenericRepository<PackageOrderer> po)
        {
            _PackageOrderer = po;
        }

        public List<PackageOrderer> GetPackageOrdererList()
        {
            return _PackageOrderer.GetAllData();
        }
        public PackageOrderer GetByIdPackageOrdererList(int id)
        {
            return _PackageOrderer.GetById(id);

        }

        public bool PostpackageOrdererList(PackageOrderer po)
        {

            return _PackageOrderer.AddData(po);

        }
        public bool PutpackageOrdererList(int poid, PackageOrderer po)
        {
            return _PackageOrderer.UpdateData(poid, po);

        }
        public bool DeletePackageOrderer(int id)
        {

            return _PackageOrderer.DeleteData(id);
        }
    }

}
