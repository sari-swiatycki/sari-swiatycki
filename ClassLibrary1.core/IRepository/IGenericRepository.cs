using ClassLibrary1.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.IRepository
{
    public interface IGenericRepository<T>
    {
         List<T> GetAllData();
         T GetById(int id);
         bool AddData(T t);


        bool UpdateData(int id, T t);

        bool DeleteData(int id);




       
    }
}
