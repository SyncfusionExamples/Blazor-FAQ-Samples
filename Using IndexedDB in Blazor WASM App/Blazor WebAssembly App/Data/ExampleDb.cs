using IndexedDB.Blazor;
using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations;

namespace Blazor_WebAssembly_App.Data
{
    public class ExampleDb : IndexedDb
    {
        public ExampleDb ( IJSRuntime jSRuntime, string name, int version ) : base(jSRuntime, name, version) { }

        // These are like tables. Declare as many of them as you want.
        public IndexedSet<Person> People { get; set; }
    }

    public class Person
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }
    }
}
