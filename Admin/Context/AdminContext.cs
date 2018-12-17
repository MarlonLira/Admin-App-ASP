using Admin.Models;
using System.Data.Entity;

namespace Admin.Context
{
    public class AdminContext : DbContext
    {
        public AdminContext() : base("Admin") { }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}