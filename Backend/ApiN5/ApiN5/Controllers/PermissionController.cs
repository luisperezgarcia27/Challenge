using ApiN5.Models.Nf;
using ApiN5.Models.PermisoM;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiN5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        // GET: api/<PermissionController>
        [HttpGet]
        public List<PermissionModel> Get()
        {
            PermissionM model = new PermissionM();
            return model.Read();
        }

        // GET api/<PermissionController>/5
        [HttpGet("{id}")]
        public Permiso Get(int id)
        {
            PermissionM model = new PermissionM();
            return model.ReadId(id);
        }

        // POST api/<PermissionController>
        [HttpPost]
        public void Create(PermissionModel Data)
        {
            PermissionM model = new PermissionM();
            model.Create(Data);
        }

        // PUT api/<PermissionController>/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] PermissionModel Data)
        {
            PermissionM model = new PermissionM();
            model.Update(id, Data);
        }

        // DELETE api/<PermissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
