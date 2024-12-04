using ClassLibrary1.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.IService
{
    public interface IPaymentService
    {
        List<Payment> GetPaymentsList();
        Payment GetByIdPaymentsService(int id);
        bool PostPaymentsList(Payment payment);
        bool PutPaymentsList(int id, Payment payment);
        bool DeletePaymentsList(int id);
    }
}
