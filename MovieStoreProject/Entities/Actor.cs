using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieStoreProject.Entities
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string ActorSurname { get; set; }
        public List<Movie> Movie { get; set; }
    }
}