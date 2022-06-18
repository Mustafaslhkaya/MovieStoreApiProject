using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStoreProject.Entities;

namespace MovieStoreProject.Configurations
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie()
            {
                MovieId=1,
                MovieName="Movie1",
                MovieYear=System.DateTime.Now,
                MovieCategory=CategoryEnum.Horror,
                Price=1500,
                DirectorId=1,
                

            },
                new Movie()
                {
                    MovieId = 2,
                    MovieName = "Movie2",
                    MovieYear = System.DateTime.Now,
                    MovieCategory = CategoryEnum.Comedy,
                    Price = 1502,
                    DirectorId = 2,


                },
                new Movie()
                {
                    MovieId = 3,
                    MovieName = "Movie3",
                    MovieYear = System.DateTime.Now,
                    MovieCategory = CategoryEnum.Thriller,
                    Price = 1000,
                    DirectorId = 1,


                },
                new Movie()
                {
                    MovieId = 4,
                    MovieName = "Movie4",
                    MovieYear = System.DateTime.Now,
                    MovieCategory = CategoryEnum.Horror,
                    Price = 100,
                    DirectorId = 4,


                },
                new Movie()
                {
                    MovieId = 5,
                    MovieName = "Movie5",
                    MovieYear = System.DateTime.Now,
                    MovieCategory = CategoryEnum.Action,
                    Price = 350,
                    DirectorId = 3,


                },
                new Movie()
                {
                    MovieId = 6,
                    MovieName = "Movie6",
                    MovieYear = System.DateTime.Now,
                    MovieCategory = CategoryEnum.Comedy,
                    Price = 500,
                    DirectorId = 5,


                },
                new Movie()
                {
                    MovieId = 7,
                    MovieName = "Movie7",
                    MovieYear = System.DateTime.Now,
                    MovieCategory = CategoryEnum.Action,
                    Price = 700,
                    DirectorId = 6,


                },
                new Movie()
                {
                    MovieId = 8,
                    MovieName = "Movie8",
                    MovieYear = System.DateTime.Now,
                    MovieCategory = CategoryEnum.Thriller,
                    Price = 850,
                    DirectorId = 6,


                }
            );
        }
    }
}
