using CountryService.Model;
using Microsoft.EntityFrameworkCore;

namespace CountryService.DAL
{
    public class CountryContext :DbContext  //Context
    {
        public CountryContext(DbContextOptions<CountryContext> options):base(options)
        {
              
        }
        public DbSet<CountryModel> Country{ get;  set; }
    }
}
