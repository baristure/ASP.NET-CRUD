using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
               
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
    }
}
