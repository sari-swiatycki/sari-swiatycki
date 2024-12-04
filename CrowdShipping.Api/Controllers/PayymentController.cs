using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IService;
using Crowdshipping.Service.services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrowdShipping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayymentController : ControllerBase
    {
        readonly IPaymentService _PaymentService;

        public PayymentController(IPaymentService p)
        {
            _PaymentService = p;
        }

        // GET: api/<PaymentController>
        [HttpGet]
        public ActionResult<List<Payment>> Get()
        {
            return _PaymentService.GetPaymentsList();
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id}")]



        public ActionResult<Payment> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            Payment result = _PaymentService.GetByIdPaymentsService(id);
            if (result == null)
                return NotFound();
            return result;

        }



        // POST api/<PaymentController>
        [HttpPost]
        public ActionResult Post([FromBody] Payment value)
        {

            if (value == null)
            {
                return BadRequest();
            }
            return Ok(_PaymentService.PostPaymentsList(value));
        }




        // PUT api/<PaymentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Payment value)
        {
            if (value == null || id < 0)
                return BadRequest();
            return Ok(_PaymentService.PutPaymentsList( id, value));
        }


        // DELETE api/<PaymentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            if (id < 0)
                return BadRequest();

            bool result = _PaymentService.DeletePaymentsList(id);
            if (!result)
                return NotFound();
            return Ok(result);
        }
    }
}
