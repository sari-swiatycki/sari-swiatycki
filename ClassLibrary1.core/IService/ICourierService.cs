using ClassLibrary1.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.IService
{
    public interface ICourierService
    {
        List<Courier> GetCouriersList();

        Courier GetByIdCourierList(int id);

        bool PostCouriersList(Courier courier);
        bool PutCourierList(int id, Courier courier);
        bool DeleteCourierList(int id);


    }
}
