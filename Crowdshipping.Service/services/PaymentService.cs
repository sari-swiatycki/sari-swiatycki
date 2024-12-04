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
    public class PaymentService:IPaymentService
    {
        readonly IGenericRepository<Payment> _PaymentService;
        public PaymentService(IGenericRepository<Payment> sr)
        {
            _PaymentService = sr;
        }

        public List<Payment> GetPaymentsList()
        {
            return _PaymentService.GetAllData();
        }
        public Payment GetByIdPaymentsService(int id)
        {
            return _PaymentService.GetById(id);

        }

        public bool PostPaymentsList(Payment ship)
        {

            return _PaymentService.AddData(ship);

        }
        public bool PutPaymentsList(int shipmentID, Payment ship)
        {
            return _PaymentService.UpdateData(shipmentID, ship);

        }
        public bool DeletePaymentsList(int id)
        {

            return _PaymentService.DeleteData(id);
        }
    }
}

