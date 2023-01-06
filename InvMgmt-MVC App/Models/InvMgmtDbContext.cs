using Microsoft.EntityFrameworkCore;

namespace InvMgmt_MVC_App.Models
{
    public class InvMgmtDbContext:DbContext
    {

        public InvMgmtDbContext(DbContextOptions<InvMgmtDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
