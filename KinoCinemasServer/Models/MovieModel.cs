using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemasProj.Models
{
    public class MovieModel
    {
        #region Ctor
        public MovieModel(int id, string name, string genre, decimal price, decimal lenght, string cinemaId)
        {
            this.ID = id;
            this.Name = name;
            this.Genre = genre;
            this.Price = price;
            this.Lenght = lenght;
            this.CinemaId = cinemaId;
        }
        #endregion Ctor

        #region Data Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public decimal Lenght { get; set; }
        public string CinemaId { get; set; }
        #endregion Data Properties
    }
}
