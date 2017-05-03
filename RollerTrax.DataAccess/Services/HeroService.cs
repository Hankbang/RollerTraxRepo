using RollerTrax.DataAccess.Entities;
using RollerTrax.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerTrax.DataAccess.Services
{
    public class HeroService
    {
        public static IEnumerable<Hero> GetAll()
        {
            using (var ctx = new TraxDbContext())
            {
                return ctx.Heroes.Select(h => h).ToList();
            }
        }

        public static void Insert(Hero newHero)
        {
            using (var ctx = new TraxDbContext())
            {
                ctx.Heroes.Add(newHero);
                ctx.SaveChanges();
            }
        }
    }
}
