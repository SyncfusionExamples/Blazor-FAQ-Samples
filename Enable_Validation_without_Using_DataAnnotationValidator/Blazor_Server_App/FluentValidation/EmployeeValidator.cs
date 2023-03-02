using FluentValidation;
namespace Blazor_Server_App.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator ()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("You   must enter a valid name.");
            RuleFor(p => p.Name).MaximumLength(20).WithMessage("The   name cannot be more than 20 characters long.");
            RuleFor(p => p.Organization).NotEmpty().WithMessage("You   must enter a valid organization name.");
        }
    }
}
