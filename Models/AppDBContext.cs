using Microsoft.EntityFrameworkCore;

namespace DrankAPI.Models{
    public class AppDBContext : DbContext{
        public AppDBContext(DbContextOptions<AppDBContext> options)
                 : base(options)
        {
            
        }

        public DbSet<Drank> Dranken {get; set;}
    }
}