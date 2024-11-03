using dress_rent.entities;
using dress_rent.servise;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        static order_detail_service order_detail_service = new order_detail_service();

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<order_details>> Get()
        {
            List<order_details> result = order_detail_service.GetList();
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<order_details> Get(int id)
        {
            if (id < 0) return Unauthorized();
            order_details result = order_detail_service.GetById(id);
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] order_details d)
        {
            bool success = order_detail_service.AddOrder_Detail(d);
            return Ok(success);

        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] order_details d)
        {
            bool flag = order_detail_service.Update(id, d);
            return Ok(flag);

        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool sucess = order_detail_service.Remove(id); return Ok(sucess);
        }
    }
}
