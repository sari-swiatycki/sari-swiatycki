using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IService;
using Crowdshipping.Service.services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrowdShipping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {

        readonly IShipmentService _shipmentService;
        public ShipmentController(IShipmentService s)
        {
            _shipmentService= s;
        }



        // GET: api/<ShipmentController>
        [HttpGet]
        public ActionResult< IEnumerable<Shipment>> Get()
        {
            return _shipmentService.GetShipmentList();
        }

      

        // GET api/<ShipmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Shipment> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            Shipment result = _shipmentService.GetByIdShipmentService(id);
            if (result == null)
                return NotFound();
            return result;

        }

        // POST api/<ShipmentController>
        [HttpPost]
        public ActionResult Post([FromBody] Shipment value)
        {

            if (value == null)
            {
                return BadRequest();
            }
            return Ok(_shipmentService.PostShipmentList(value));
        }

        // PUT api/<ShipmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Shipment value)
        {
            if (value == null || id < 0)
                return BadRequest();
            return Ok(_shipmentService.PutShipmentsList(id, value));
        }

        // DELETE api/<ShipmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest();

            bool result = _shipmentService.DeleteShipmentList(id);
            if (!result)
                return NotFound();
            return Ok(result);
        }

    }
}
