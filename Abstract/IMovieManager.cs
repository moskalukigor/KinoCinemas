using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas.Abstract
{
    public interface IMovieManager
    {
        IEnumerable<Movie> GetAll();

        void Add(Movie Item);
    }
}
