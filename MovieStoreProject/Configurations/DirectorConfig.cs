using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStoreProject.Entities;

namespace MovieStoreProject.Configurations
{
    public class DirectorConfig : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasData(
                new Director()
                 {
                    DirectorId=1,
                    DirectorName="Director1",
                    DirectorSurname="DirectorSurname2",
                    
                 },
                new Director()
                {
                    DirectorId = 2,
                    DirectorName = "Director2",
                    DirectorSurname = "DirectorSurname3",

                },
                new Director()
                {
                    DirectorId = 3,
                    DirectorName = "Director3",
                    DirectorSurname = "DirectorSurname3",

                },
                new Director()
                {
                    DirectorId = 4,
                    DirectorName = "Director4",
                    DirectorSurname = "DirectorSurname4",

                },
                new Director()
                {
                    DirectorId = 5,
                    DirectorName = "Director5",
                    DirectorSurname = "DirectorSurname5",

                },
                new Director()
                {
                    DirectorId = 6,
                    DirectorName = "Director6",
                    DirectorSurname = "DirectorSurname6",

                }



                );
                
        }
    }
}
