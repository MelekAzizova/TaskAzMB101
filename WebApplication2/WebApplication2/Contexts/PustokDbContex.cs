using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Contexts
{
    public class PustokDbContex:DbContext
    {
        public DbSet<Slider> Sliders { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-RD495BO\SQLEXPRESS;Database = Pustok;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
