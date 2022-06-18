using AutoMapper;
using MovieStoreProject.Entities;
using MovieStoreProject.Models.ActorModels;

namespace MovieStoreProject.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AddActorModel, Actor>();
        }
    }
}
