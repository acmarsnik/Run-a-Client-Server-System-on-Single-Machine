using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SakilaWebServer.Models;

namespace SakilaWebServer.Controllers
{

    [Route("api/[controller]")]
    public class FilmsController : Controller
    {

        private SakilaDbContext dbContext;

        public FilmsController()
        {
            string connectionString = "server=localhost;port=3306;database=sakila;userid=root;pwd=fYoTO!N1J8nw;sslmode=none";
            dbContext = SakilaDbContextFactory.Create(connectionString);
        }

        // GET api/Films
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(dbContext.Film.ToArray());
        }

        // GET api/Films/101
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var film = dbContext.Film.SingleOrDefault(a => a.Film_ID == id);
            if (film != null)
            {
                return Ok(film);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/Films
        [HttpPost]
        public ActionResult Post([FromBody]Film film)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dbContext.Film.Add(film);
            dbContext.SaveChanges();
            return Created("api/Films", film);
        }

        // PUT api/Films/101
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Film film)
        {
            var target = dbContext.Film.SingleOrDefault(a => a.Film_ID == id);
            if (target != null && ModelState.IsValid)
            {
                dbContext.Entry(target).CurrentValues.SetValues(film);
                dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/Films/101
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var film = dbContext.Film.SingleOrDefault(a => a.Film_ID == id);
            if (film != null)
            {
                dbContext.Film.Remove(film);
                dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}