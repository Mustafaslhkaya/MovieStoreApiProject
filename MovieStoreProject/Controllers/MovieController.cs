using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieStoreProject.DataAccess;
using MovieStoreProject.Entities;
using MovieStoreProject.Models.MovieModels;
using MovieStoreProject.Models.MovieModels.Add;
using System;
using System.Collections.Generic;
using System.Linq;




namespace MovieStoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        
        private readonly Context _context;

        public MovieController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public List<GetMovieModel> GetMovieList()
        {
            var movielist = _context.Movies.OrderBy(x => x.MovieId).ToList<Movie>();
            List<GetMovieModel> modellist=new List<GetMovieModel>();
            foreach (var movie in movielist)
            {
                modellist.Add(new GetMovieModel()
                {
                    MovieName= movie.MovieName,
                    MovieYear=movie.MovieYear,
                    MovieCategory=movie.MovieCategory,
                    Price=movie.Price
                });
            }
            return modellist;
        }

        [HttpPost]
        public void AddMovie([FromBody] AddMovieModel model)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieName == model.MovieName);
            if (movie is not null)
            {
                throw new InvalidOperationException("Bu film zaten mevcut.");
            }

            movie = new Movie();
            movie.MovieName = model.MovieName;
            movie.MovieYear = model.MovieYear;
            movie.MovieCategory = model.MovieCategories;
            movie.Price = model.Price;
            movie.DirectorId = model.DirectorId;

            AddMovieValidator validator = new AddMovieValidator();
            validator.ValidateAndThrow(model);

            _context.Movies.Add(movie);
            _context.SaveChanges();




        }

        [HttpPut]
        public void UpdateMovie(UpdateMovieModel model)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieName == model.MovieName);
            if (movie is null)
            {
                throw new InvalidOperationException("Böyle bir film bulunamadı.");

            }
            movie.MovieName=model.MovieName!= default ? model.MovieName :movie.MovieName;
            movie.MovieYear = model.MovieYear != default ? model.MovieYear : movie.MovieYear;
            movie.Price = model.Price != default ? model.Price : movie.Price;
            _context.SaveChanges();
            
            
        }
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieId == id);
            if (movie is null)
            {
                throw new InvalidOperationException("Böyle bir film bulunamadı.");
            }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }
}
