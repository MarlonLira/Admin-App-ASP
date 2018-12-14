using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Admin.Context
{
    public class AdminContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
    }
}