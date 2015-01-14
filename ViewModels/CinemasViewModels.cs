using Cinemas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas.ViewModels
{
    public class CinemasViewModels
    {
        private readonly ICinemasManager _cinemasManager;

        List<CinemasModel> _items = null;
        List<Cinemas> _items = null;

        public List<CinemasModel> CreateCinemasModel(IEnumerable<Cinemas> cinemas)
        {
            List<CinemasModel> listCinemasModel = new List<CinemasModel>();

            var _res =
                from c in cinemas
                select new
                {
                    Id = c.Id,
                    Name = c.Name,                    
                };

            foreach (var c in _res)
            {
                listCinemasModel.Add(new CinemasModel(
                    c.Id, c.Name));
            }

            return listCinemasModel;
        }


    }
}
