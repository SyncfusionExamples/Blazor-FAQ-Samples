using System.ComponentModel.DataAnnotations;
namespace Add_Custom_CSS_in_Blazor
{
    public class Customer
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "The organization code must be less than 5   characters in length.")]
        public string? OrganizationCode { get; set; }
    }
}
