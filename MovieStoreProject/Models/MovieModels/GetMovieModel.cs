using MovieStoreProject.DataAccess;
using MovieStoreProject.Entities;
using System;
using System.Linq;

namespace MovieStoreProject.Models.MovieModels
{
    public class GetMovieModel
    {

        public string MovieName { get; set; }
        public DateTime MovieYear { get; set; }
        public CategoryEnum MovieCategory { get; set; }
        public decimal Price { get; set; }


    }
}
