using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieStoreProject.Entities
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }
        public string DirectorSurname { get; set; }
        public List<Movie> Movie { get; set; }
    }
}