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
            return new Hero[] 
            {
                  new Hero { id = 11, name = "Mr. Nice" },
                  new Hero { id = 12, name = "Narco" },
                  new Hero { id = 13, name = "Bombasto" },
                  new Hero { id = 14, name = "Celeritas" },
                  new Hero { id = 15, name = "Magneta" },
                  new Hero { id = 16, name = "RubberMan" },
                  new Hero { id = 17, name = "Dynama" },
                  new Hero { id = 18, name = "Dr IQ" },
                  new Hero { id = 19, name = "Magma" },
                  new Hero { id = 20, name = "Tornado" }
            };
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
