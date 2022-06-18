
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieStoreProject.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieYear { get; set; }
        public CategoryEnum MovieCategory { get; set; }
        public Director Director { get; set; }
        public int DirectorId { get; set; }


        public List<Actor> Actor { get; set; }
        public decimal Price { get; set; }
        public List<Customer> Customer { get; set; }



    }
}
