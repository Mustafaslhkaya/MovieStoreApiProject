using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreProject.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
