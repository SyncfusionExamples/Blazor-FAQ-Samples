using BlazorServerApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Services
{
    public class EmpService 
    {
        protected readonly ApplicationDbContext? _dbcontext;
        public EmpService ( ApplicationDbContext? _db )
        {
            _dbcontext = _db;
        }
        public EmpClass AddNewRec ( EmpClass? ec)
        {
            _dbcontext!.Database.ExecuteSqlRaw("InsertEmpdetails {0},{1},{2}", ec?.Empname!, ec?.Department!, ec!.Joindate);
            _dbcontext.SaveChanges();
            return ec;
        }

    }
}
