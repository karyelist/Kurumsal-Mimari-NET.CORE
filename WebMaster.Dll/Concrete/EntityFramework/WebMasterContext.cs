using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMaster.Entities.Concrete;

namespace WebMaster.Dal.Concrete.EntityFramework
{
    public class WebMasterContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FUO4CUS;Database=WebMasterDb;Trusted_Connection=true;");
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<PageMedia> PageMedia { get; set; }
        public DbSet<User> User { get; set; }

 
    }
}
