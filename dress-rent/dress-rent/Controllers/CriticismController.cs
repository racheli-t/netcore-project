using dress_rent.entities;
using dress_rent.servise;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dress_rent.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class CriticismController : ControllerBase
    {
       static criticism_service criticism_service = new criticism_service();

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<criticism>> Get()
        {
            List<criticism> result = criticism_service.GetList();
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<criticism> Get(int id)
        {
            if (id < 0) return Unauthorized();
            criticism result = criticism_service.GetById(id);
            if (result == null) { return Unauthorized(); }
            return result;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] criticism d)
        {
            bool success = criticism_service.Addcriticism(d);
            return Ok(success);

        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] criticism d)
        {
            bool flag = criticism_service.Update(id, d);
            return Ok(flag);

        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool sucess = criticism_service.Remove(id); return Ok(sucess);
        }
    }
}

