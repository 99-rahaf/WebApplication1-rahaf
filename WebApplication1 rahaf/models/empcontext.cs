using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1_rahaf.models
{
    public class empcontext : DbContext
    {
        public empcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<employee> employees { get; set; }
        public DbSet <Department> Departments { get; set; }
            
        {
            
        }
    }
}
