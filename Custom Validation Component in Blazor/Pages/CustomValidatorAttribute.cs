using System.ComponentModel.DataAnnotations;
namespace BlazorServerApp.Pages
{
    public class CustomValidationAttribute : ValidationAttribute
    {
        public string? ValidPassword { get; set; }

        protected override ValidationResult? IsValid ( object? password, ValidationContext validationContext )
        {
            var content = password?.ToString()?.ToLower();
            if (content!.Equals(ValidPassword?.ToLower()))
            {
                return null;
            }
            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
