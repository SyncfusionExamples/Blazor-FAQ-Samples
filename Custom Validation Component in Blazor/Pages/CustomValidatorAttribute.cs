using System.ComponentModel.DataAnnotations;
namespace BlazorServerApp.Pages
{
    public class CustomValidationAttribute : ValidationAttribute
    {
        public string? ValidUserName { get; set; }

        protected override ValidationResult? IsValid ( object? username, ValidationContext validationContext )
        {
            var content = username?.ToString()?.ToLower();
            if (content!.Equals(ValidUserName?.ToLower()))
            {
                return null;
            }
            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
