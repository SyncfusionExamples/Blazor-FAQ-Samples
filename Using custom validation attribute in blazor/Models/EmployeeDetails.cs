using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models
{
    public class EmployeeDetails
    {
        [Required]
        public string? Name { get; set; }
        //Here OrganizationValidation is a Customvalidation Attribute
        [Required]
        [OrganizationValidation(ErrorMessage = "Invalid customer   log-in.", ValidOrganizationName = "Syncfusion")]
        public string? Organization { get; set; }
    }
}
