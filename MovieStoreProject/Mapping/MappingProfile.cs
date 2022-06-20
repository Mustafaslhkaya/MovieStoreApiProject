using AutoMapper;
using MovieStoreProject.Entities;
using MovieStoreProject.Models.ActorModels;
using MovieStoreProject.Models.CustomerModels;
using MovieStoreProject.Models.MovieModels;

namespace MovieStoreProject.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AddActorModel, Actor>();
            CreateMap<AddMovieModel, Movie>().ForMember(dest => dest.MovieCategory, opt => opt.MapFrom(src => src.MovieCategories.GetHashCode()));
            CreateMap<AddCustomerModel,Customer>().ForMember(dest=> dest.FavouriteCategories,opt=>opt.MapFrom(src=> src.FavouriteCategories.GetHashCode()));
        }
    }
}
