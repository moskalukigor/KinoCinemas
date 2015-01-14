using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas.Abstract
{
    class CinemasManager : AbstractManager, ICinemasManager
    {        
        public CinemasManager(string connectionString) : base(connectionString) { }

        public IEnumerable<Cinemas> GetAll()
        {
            using (DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Cinemas>().ToList();
            }
        }

        public void Add(Cinemas Item)
        {
            using (var ctx = this.CreateDbContext())
            {
                ctx.Set<Cinemas>().Add(Item);
                ctx.SaveChanges();
            }
        }
    }
}
