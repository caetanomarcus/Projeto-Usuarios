using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projeto_Usuários.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        readonly List<User> Users = new List<User>
        {
        new User("1", "Marcus", "marcus.god@hotmail.com", "123", "975704593"),
        new User("2","Vinicius", "vinicius.god@hotmail.com", "456", "975704593"),
        new User("3","Caetano", "caetano.god@hotmail.com", "789", "975704593")
        };

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(string id)
        {
            return Users.Find(x => x.Id == id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
