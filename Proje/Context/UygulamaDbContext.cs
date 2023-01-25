using M_Proje.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Proje.Context
{
    public class UygulamaDbContext:DbContext
    {
        public DbSet<Admin> Adminler => Set<Admin>();
        public DbSet<Kullanici> Kullanicilar => Set<Kullanici>();        
        public DbSet<Besin> Besinler => Set<Besin>();
        public DbSet<Ogun> Ogunler => Set<Ogun>();
        public DbSet<Egitmen> Egitmenler => Set<Egitmen>();
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=DiyetProjeDb;Integrated Security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogun>().HasData(
                new Ogun() { Id=1,Zaman="Sabah"},
                new Ogun() { Id=2,Zaman="Öğle"},
                new Ogun() { Id=3,Zaman="Akşam"}
                );
        }

    }
}
