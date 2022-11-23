using PrestaFacil.Models;
using Microsoft.EntityFrameworkCore;

namespace PrestaFacil
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ToDo> ToDo{ get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
