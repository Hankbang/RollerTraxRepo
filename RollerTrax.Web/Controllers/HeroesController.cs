using RollerTrax.DataAccess.Services;
using RollerTrax.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RollerTrax.Web.Controllers
{
    public class HeroesController : ApiController
    {
        // GET: api/Heroes
        public IEnumerable<Hero> Get()
        {
            var allHeroes = HeroService.GetAll();

            return allHeroes.Select(h => new Hero { id = h.Id, name = h.Name });
        }

        // GET: api/Heroes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Heroes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Heroes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Heroes/5
        public void Delete(int id)
        {
        }
    }
}
