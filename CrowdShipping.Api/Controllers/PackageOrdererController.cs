using ClassLibrary1.core.Entities;
using ClassLibrary1.core.IService;
using Crowdshipping.Service.services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrowdShipping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageOrdererController : ControllerBase
    {

        readonly IPackageOrdererService _PackageOrdererService;


        public PackageOrdererController(IPackageOrdererService p)
        {
            _PackageOrdererService= p;
        }
        // GET: api/<PackageOrdererController>
        [HttpGet]
        public ActionResult<List<PackageOrderer>> Get()
        {
            return _PackageOrdererService.GetPackageOrdererList();
        }

        // GET api/<PackageOrdererController>/5
        [HttpGet("{id}")]


        public ActionResult<PackageOrderer> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            PackageOrderer result = _PackageOrdererService.GetByIdPackageOrdererList(id);
            if (result == null)
                return NotFound();
            return result;

        }

        // POST api/<PackageOrdererController>
        [HttpPost]
        public ActionResult Post([FromBody] PackageOrderer value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            return Ok(_PackageOrdererService.PostpackageOrdererList(value));
        }


        // PUT api/<PackageOrdererController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PackageOrderer value)
        {
            //if (!valid.isvalidemail(value.Email) || !valid.IsphoneValid(value.Email))
            //    return BadRequest();
            if (value == null || id < 0)
                return BadRequest();
            return Ok(_PackageOrdererService.PutpackageOrdererList( id, value));

        }


        // DELETE api/<PackageOrdererController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            if (id < 0)
                return BadRequest();

            bool result = _PackageOrdererService.DeletePackageOrderer(id);
            if (!result)
                return NotFound();
            return Ok(result);
        }


    }
}
