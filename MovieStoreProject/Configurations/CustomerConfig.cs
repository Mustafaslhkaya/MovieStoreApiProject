using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStoreProject.Entities;

namespace MovieStoreProject.Configurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer()
            {
                CustomerId=1,
                CustomerName="Customer1",
                CustomerSurname="CustomerSurname1",
                FavouriteCategories=CategoryEnum.Horror
                
            },
                new Customer()
                {
                    CustomerId = 2,
                    CustomerName = "Customer2",
                    CustomerSurname = "CustomerSurname2",
                    FavouriteCategories = CategoryEnum.Action

                },
                new Customer()
                {
                    CustomerId = 3,
                    CustomerName = "Customer3",
                    CustomerSurname = "CustomerSurname3",
                    FavouriteCategories = CategoryEnum.Comedy

                },
                new Customer()
                {
                    CustomerId = 4,
                    CustomerName = "Customer4",
                    CustomerSurname = "CustomerSurname4",
                    FavouriteCategories = CategoryEnum.Horror

                },
                new Customer()
                {
                    CustomerId = 5,
                    CustomerName = "Customer5",
                    CustomerSurname = "CustomerSurname5",
                    FavouriteCategories = CategoryEnum.Thriller

                },
                new Customer()
                {
                    CustomerId = 6,
                    CustomerName = "Customer6",
                    CustomerSurname = "CustomerSurname6",
                    FavouriteCategories = CategoryEnum.Thriller

                }
            );
        }
    }
}
