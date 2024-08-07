using Microsoft.EntityFrameworkCore;
using web_api_store.Domains;

namespace web_api_store.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()
        {
            
        }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("Data Source=NOTE20-SALA19\\SQLEXPRESS; initial catalog=ProductDb_manha; user Id=sa; pwd=Senai@134 ; TrustServerCertificate=true");

        public DbSet<Products> Products { get; set; }
    }
}
