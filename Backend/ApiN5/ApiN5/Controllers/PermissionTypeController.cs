using ApiN5.Models.Nf;
using ApiN5.Models.PermissionTypeM;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiN5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionTypeController : ControllerBase
    {
        // GET: api/<PermissionTypeController>
        [HttpGet]
        public List<TipoPermiso> Get()
        {
            PermissionTypeM model = new PermissionTypeM();
            return model.Read();
        }

        // GET api/<PermissionTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PermissionTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PermissionTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PermissionTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
