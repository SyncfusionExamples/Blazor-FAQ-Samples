using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models
{
    public class OrganizationValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid ( object? value, ValidationContext? validationContext )
        {
            if (value==null)
            {
                var errorMessage = FormatErrorMessage(validationContext!.DisplayName);
                return new ValidationResult(errorMessage,new string[] {validationContext!.MemberName});
            }
            return ValidationResult.Success;
        }
    }
}
