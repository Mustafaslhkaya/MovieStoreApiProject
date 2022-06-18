
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieStoreProject.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public List<Movie> Movie { get; set; }
        public CategoryEnum FavouriteCategories { get; set; }
    }
    public enum CategoryEnum
    {
        Thriller = 1,
        Horror,
        Comedy,
        Action
    }
}
