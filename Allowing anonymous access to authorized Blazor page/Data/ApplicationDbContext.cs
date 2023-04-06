using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Server_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext ( DbContextOptions<ApplicationDbContext> options )
            : base(options)
        {
        }
    }
}