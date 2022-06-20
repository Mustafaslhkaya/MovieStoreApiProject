using FluentValidation;

namespace MovieStoreProject.Models.CustomerModels
    
{
    public class AddCustomerValidator : AbstractValidator<AddCustomerModel>
    {
        public AddCustomerValidator()
        {
            RuleFor(command => command.FavouriteCategories).IsInEnum<AddCustomerModel, Entities.CategoryEnum>();
            RuleFor(command => command.CustomerName).MinimumLength(2);
            RuleFor(command => command.CustomerSurname).MinimumLength(2);
        }

    }
    
}
