using GorevAtama_Project.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Data.Concrete.EfCore
{
    public class GorevAtama_ProjectContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Islem> Islems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-OFVK2FD; Database = GorevAtamax_Db; User = sa; Password = 123");
        }
    }
}
