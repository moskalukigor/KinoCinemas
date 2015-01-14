using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas.Models
{
    public class CinemasModel
    {
        #region Ctor
        public CinemasModel(int id, string name/*, string nameMovie, string nameCinema, string genre, decimal price, decimal lenght*/)
        {
            this.ID = id;
            this.Name = name;
            /*this.NameCinema = nameCinema;
            this.Genre = genre;
            this.Price = price;
            this.Lenght = lenght;*/

        }
        #endregion Ctor

        #region Data Properties
        public int ID { get; set; }
        public string Name { get; set; }
       /*public string NameCinema { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public decimal Lenght { get; set; }*/
        #endregion Data Properties

    }
}
