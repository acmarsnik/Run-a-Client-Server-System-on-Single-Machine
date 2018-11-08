using Microsoft.AspNetCore.Mvc;
using WebServer.Models;
using System.Linq;


namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        [HttpGet]
        public Person[] Get()
        {
            return Repository.People.ToArray();
        }
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return Repository.GetPersonByID(id);
        }
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            Repository.AddPerson(person);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Person person)
        {
            Repository.ReplacePersonByID(id, person);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Repository.RemovePersonByID(id);
        }
    }
}