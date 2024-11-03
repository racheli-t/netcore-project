using dress_rent.entities;
using dress_rent.servise;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        static order_service order_service = new order_service();

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<order>> Get()
        {
            List<order> result = order_service.GetList();
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<order> Get(int id)
        {
            if (id < 0) return Unauthorized();
            order result = order_service.GetById(id);
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] order d)
        {
            bool success = order_service.AddOreder(d);
            return Ok(success);

        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] order d)
        {
            bool flag = order_service.Update(id, d);
            return Ok(flag);

        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool sucess = order_service.Remove(id); return Ok(sucess);
        }
    }
}
