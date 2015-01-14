using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas
{
    public interface ICinemasManager
    {
        IEnumerable<Cinemas> GetAll();

        void Add(Cinemas Item);
    }
}
