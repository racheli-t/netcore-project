using dress_rent.entities;
using dress_rent.servise;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static customer_service customer_service = new customer_service();

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<customer>> Get()
        {
            List<customer> result = customer_service.GetList();
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<customer> Get(int id)
        {
            if (id < 0) return Unauthorized();
            customer result = customer_service.GetById(id);
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] customer d)
        {
            bool success = customer_service.AddCustomer(d);
            return Ok(success);

        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] customer d)
        {
            bool flag = customer_service.Update(id, d);
            return Ok(flag);

        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool sucess = customer_service.Remove(id); return Ok(sucess);
        }
    }
}
