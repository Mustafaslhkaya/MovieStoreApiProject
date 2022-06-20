using MovieStoreProject.Entities;
using System;

namespace MovieStoreProject.Models.MovieModels
{
    public class AddMovieModel
    {
        public string MovieName { get; set; }
        public DateTime MovieYear { get; set; }
        public decimal Price { get; set; }
        public CategoryEnum MovieCategories { get; set; }

        public int DirectorId { get; set; }

    }
}
