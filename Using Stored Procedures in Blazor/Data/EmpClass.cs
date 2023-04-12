using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Data
{
    public class EmpClass
    {
        [Key]
        public int Empid { get; set; }
        public string? Empname { get; set; }
        public string? Department { get; set; }
        public DateTime Jointdate { get; set;}

    }
}
