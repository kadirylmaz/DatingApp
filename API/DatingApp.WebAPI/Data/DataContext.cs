
using DatingApp.WebAPI.Entites;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<AppUser> AppUsers { get; set; }     
        
    }
}