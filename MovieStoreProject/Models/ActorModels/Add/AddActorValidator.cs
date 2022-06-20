using FluentValidation;

namespace MovieStoreProject.Models.ActorModels
{
    public class AddActorValidator:AbstractValidator<AddActorModel>
    {
        public AddActorValidator()
        {
            RuleFor(command => command.ActorName).MinimumLength(2);
            RuleFor(command => command.ActorSurname).NotNull();
        }
    }
}
