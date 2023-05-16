using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models
{
    public class OrganizationValidationAttribute : ValidationAttribute
    {
        public string? ValidOrganizationName { get; set; }
        protected override ValidationResult? IsValid ( object? value, ValidationContext? validationContext )
        {
            string fieldValue = value!.ToString()!.ToLower();
            if (fieldValue.Equals(ValidOrganizationName?.ToLower()))
                return null;
            return new ValidationResult(ErrorMessage, new[] { validationContext?.MemberName }.Cast<string>());

        }
    }
}
