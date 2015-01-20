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

        List<MovieModel> _movieModel = null;
        List<Movie> _movie = null;

        public List<MovieModel> CreateMovieModel(IEnumerable<Movie> movie)
        {
            List<MovieModel> listMovieModel = new List<MovieModel>();

            var _res =
                from c in movie
                select new
                {
                    Id = c.Id,
                    Name = c.Name,
                    Genre = c.Genre,
                    Price = c.Price,
                    Lenght = c.Lenght,
                    CinemaId = c.CinemaId
                };

            foreach (var c in _res)
            {
                listMovieModel.Add(new MovieModel(
                    c.Id, c.Name, c.Genre, c.Price, c.Lenght, c.CinemaId));
            }

            return listMovieModel;
        }

        public MovieViewModel(IMovieManager movieManager)
        {
            _movieManager = movieManager;
        }

        public IEnumerable<MovieModel> ListMovie
        {
            get
            {
                if (_movieModel == null)
                {
                    _movieModel = CreateMovieModel(_movieManager.GetAll());
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
