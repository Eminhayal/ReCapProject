using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProjectContext : DbContext
    {
        // Veritabanı ile bağlantı kurmamızı sağlıyor 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Project;Trusted_Connection=True");//SQL Server objecte ne yazarsa onu yaz
        }

        // Veritabanındaki tablolarımız ile ilişki kurmamız için
        // DbSet<Varlıklarımız> Veritabanında neye karışılık geliyorsa yanına onu yazıyoruz veritabanındaki adı ile 

        public DbSet<Car> Cars { get; set; } // cars tablosu ile bağladımız varlığımız
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
