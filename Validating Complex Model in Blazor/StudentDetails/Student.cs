using System.ComponentModel.DataAnnotations;

namespace Validating_Complex_Model_in_Blazor.StudentDetails
{
    public class Student
    {
        public Student ()
        {
            Details = new PersonalDetails();
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Department { get; set; }
        [ValidateComplexType]
        public PersonalDetails Details { get; set; }
    }

    public class PersonalDetails
    {
        [Required]
        public int Age { get; set; }

        [Required]
        public string? Address { get; set; }
    }
}
