using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DBContext2
{
    public class TodebDbContext : DbContext
    {
        public DbSet<TblUser> Users { get; set; }
        public DbSet<TblApartment> Apartments { get; set; }

        //protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder.UseSqlServer);

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=TODEBProjeDB;Trusted_Connection=True;"));

        }

    }
}
