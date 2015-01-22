using Cinemas.Abstract;
using Cinemas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas.ViewModels
{
    public class MovieViewModel
    {
        private readonly IMovieManager _movieManager;
        private readonly ICinemasManager _cinemasManager;

        List<MovieModel> _movieModel = null;
        List<Movie> _movie = null;
        List<Cinemas> _cinemas = null;

        public List<MovieModel> CreateMovieModel(IEnumerable<Movie> movie, IEnumerable<Cinemas> cinemas)
        {
            List<MovieModel> listMovieModel = new List<MovieModel>();

            var _res =
                from c in movie
                join m in cinemas
                    on c.CinemaId equals m.Id
                select new
                {
                    Id = c.Id,
                    Name = c.Name,
                    Genre = c.Genre,
                    Price = c.Price,
                    Lenght = c.Lenght,
                    CinemaId = m.Name
                };

            foreach (var c in _res)
            {
                listMovieModel.Add(new MovieModel(
                    c.Id, c.Name, c.Genre, c.Price, c.Lenght, c.CinemaId));
            }

            return listMovieModel;
        }

        public MovieViewModel(IMovieManager movieManager, ICinemasManager cinemasManager)
        {
            _movieManager = movieManager;
            _cinemasManager = cinemasManager;
        }

        public IEnumerable<MovieModel> ListMovie
        {
            get
            {
                if (_movieModel == null)
                {
                    _movieModel = CreateMovieModel(_movieManager.GetAll(), _cinemasManager.GetAll());
                }
                return _movieModel;
            }
        }

        public IEnumerable<Movie> MOVIE
        {
            get
            {
                if (_movie == null)
                {
                    _movie = _movieManager.GetAll().ToList();
                    return _movieManager.GetAll();
                }
                return _movie;
            }
        }


    }
}
