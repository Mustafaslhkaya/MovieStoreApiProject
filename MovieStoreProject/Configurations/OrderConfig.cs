using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStoreProject.Entities;

namespace MovieStoreProject.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order()
            {
                OrderId=1,
                CustomerId=1,
                MovieId=2,
                Price=2000,
                PurchaseDate=System.DateTime.Now

            },
                new Order()
                {
                    OrderId = 2,
                    CustomerId = 3,
                    MovieId = 3,
                    Price = 1000,
                    PurchaseDate = System.DateTime.Now

                },
                new Order()
                {
                    OrderId = 3,
                    CustomerId = 6,
                    MovieId = 4,
                    Price = 2000,
                    PurchaseDate = System.DateTime.Now

                },
                new Order()
                {
                    OrderId = 4,
                    CustomerId = 5,
                    MovieId = 7,
                    Price = 2000,
                    PurchaseDate = System.DateTime.Now

                },
                new Order()
                {
                    OrderId = 5,
                    CustomerId = 3,
                    MovieId = 7,
                    Price = 2000,
                    PurchaseDate = System.DateTime.Now

                },
                new Order()
                {
                    OrderId = 6,
                    CustomerId = 2,
                    MovieId = 5,
                    Price = 2000,
                    PurchaseDate = System.DateTime.Now

                },
                new Order()
                {
                    OrderId = 7,
                    CustomerId = 3,
                    MovieId = 2,
                    Price = 2000,
                    PurchaseDate = System.DateTime.Now

                }
            );
        }
    }
}
