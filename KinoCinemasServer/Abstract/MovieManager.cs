using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemasProj.Abstract
{
    class MovieManager : AbstractManager, IMovieManager
    {
        public MovieManager(string connectionString) : base(connectionString) { }
    
        public IEnumerable<Movie> GetAll()
        {
            using (DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Movie>().ToList();
            }
        }
    
        public void Add(Movie Item)
        {
            using (var ctx = this.CreateDbContext())
            {
                ctx.Set<Movie>().Add(Item);
                ctx.SaveChanges();
            }
        }
    }
}
