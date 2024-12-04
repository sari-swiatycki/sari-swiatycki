using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IService;
using Crowdshipping.Service.services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrowdShipping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourierController : ControllerBase
    {

        readonly ICourierService _CourierService;

        public CourierController(ICourierService c)
        {
            _CourierService = c;
        }
        //ValidationCheckGeneric valid = new ValidationCheckGeneric();
        // GET: api/<CourierController>
        [HttpGet]
        public ActionResult<List<Courier>> Get()
        {
            return _CourierService.GetCouriersList();

        }


        // GET api/<CourierController>/5
        [HttpGet("{id}")]

        public ActionResult<Courier> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            Courier result = _CourierService.GetByIdCourierList(id);
            if (result == null)
                return NotFound();
            return result;

        }




        // POST api/<CourierController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Courier value)
        {
            //if (!valid.IsphoneValid(value.ContactPhone))
            //      return BadRequest();



            if (value == null)
            {
                return BadRequest();
            }
            return Ok(_CourierService.PostCouriersList(value));
         
            //if (value == null)
            //{
            //    return BadRequest();
            //}
            //return c.PostCouriersList(value);
        }

          


    // PUT api/<CourierController>/5
    [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Courier value)
        {


            //if ( !valid.IsphoneValid(value.ContactPhone))
            //    return BadRequest();
            if (value == null || id < 0)
                return BadRequest();
            bool f = _CourierService.PutCourierList(id, value);
            if (!f)
                return NotFound();
            return Ok(f);
        }

        // DELETE api/<CourierController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id < 0)
                return BadRequest();

            bool result = _CourierService.DeleteCourierList(id);
            if (!result)
                return NotFound();
            return result;
        }
    }
}


