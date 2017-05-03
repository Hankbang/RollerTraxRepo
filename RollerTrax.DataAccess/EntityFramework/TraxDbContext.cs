using RollerTrax.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerTrax.DataAccess.EntityFramework
{
    public class TraxDbContext : DbContext
    {
        public TraxDbContext() : base("name=TraxDb")
        {
        
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public virtual DbSet<Hero> Heroes { get; set; }
    }
}
