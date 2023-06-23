using IndexedDB.Blazor;
using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations;

namespace Blazor_WebAssembly_App.Data
{
    public class IndexDb : IndexedDb
    {
        public IndexDb ( IJSRuntime jSRuntime, string name, int version ) : base(jSRuntime, name, version) { }

        // These are like tables. Declare as many of them as you want.
        public IndexedSet<Employee> employee { get; set; }
    }

    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }
    }
}
