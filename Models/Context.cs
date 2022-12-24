using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace odevvv.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=siteyeni;" +
                " integrated security=true;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Hayvanlar> Hayvanlars { get; set; }
    }
}
