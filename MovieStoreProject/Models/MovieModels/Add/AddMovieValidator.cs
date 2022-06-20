using FluentValidation;
using System;

namespace MovieStoreProject.Models.MovieModels.Add
{
    public class AddMovieValidator:AbstractValidator<AddMovieModel>
    {
        public AddMovieValidator()
        {
            RuleFor(command => command.DirectorId).GreaterThan(0);
            RuleFor(command => command.MovieCategories).IsInEnum<AddMovieModel, Entities.CategoryEnum>();
            RuleFor(command => command.MovieYear.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(command=> command.Price).GreaterThan(150);
        }
    }
}
