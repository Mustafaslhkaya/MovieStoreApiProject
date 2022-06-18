using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStoreProject.Entities;

namespace MovieStoreProject.Configurations
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(
                new Actor()
            {
                 ActorId=1,
                 ActorName="Actor1",
                 ActorSurname="ActorSurname1"
            },
                 new Actor()
                 {
                     ActorId = 2,
                     ActorName = "Actor2",
                     ActorSurname = "ActorSurname2"
                 },
                  new Actor()
                  {
                      ActorId = 3,
                      ActorName = "Actor3",
                      ActorSurname = "ActorSurname3"
                  },
                   new Actor()
                   {
                       ActorId = 4,
                       ActorName = "Actor4",
                       ActorSurname = "ActorSurname4"
                   },
                    new Actor()
                    {
                        ActorId = 5,
                        ActorName = "Actor5",
                        ActorSurname = "ActorSurname5"
                    },
                     new Actor()
                     {
                         ActorId = 6,
                         ActorName = "Actor6",
                         ActorSurname = "ActorSurname6"
                     }
                );
        }
    }
}
