
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options) 
        {
        }
        public virtual DbSet<EmpClass> Insertrecord { get; set; }
    }
}
