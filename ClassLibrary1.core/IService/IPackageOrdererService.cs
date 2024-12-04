using ClassLibrary1.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.IService
{
    public interface IPackageOrdererService
    {
        List<PackageOrderer> GetPackageOrdererList();
        PackageOrderer GetByIdPackageOrdererList(int id);
        bool PostpackageOrdererList(PackageOrderer payment);
        bool PutpackageOrdererList(int id, PackageOrderer payment);
        bool DeletePackageOrderer(int id);
    }
}
