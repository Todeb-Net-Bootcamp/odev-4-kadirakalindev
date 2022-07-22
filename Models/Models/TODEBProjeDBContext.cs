using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Models.Models
{
    public partial class TODEBProjeDBContext : DbContext
    {
        public TODEBProjeDBContext()
        {
        }

        public TODEBProjeDBContext(DbContextOptions<TODEBProjeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblApartment> TblApartments { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=TODEBProjeDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblApartment>(entity =>
            {
                entity.HasKey(e => e.ApartmentId);

                entity.ToTable("tblApartment");

                entity.Property(e => e.ApartmentId).HasColumnName("apartmentID");

                entity.Property(e => e.ApartmentBlock)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("apartmentBlock")
                    .IsFixedLength(true);

                entity.Property(e => e.ApartmentFloor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("apartmentFloor")
                    .IsFixedLength(true);

                entity.Property(e => e.ApartmentNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("apartmentNo")
                    .IsFixedLength(true);

                entity.Property(e => e.ApartmentOwner)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("apartmentOwner")
                    .IsFixedLength(true);

                entity.Property(e => e.ApartmentStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("apartmentStatus")
                    .IsFixedLength(true);

                entity.Property(e => e.ApartmentType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("apartmentType")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserCarInfo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("userCarInfo")
                    .IsFixedLength(true);

                entity.Property(e => e.UserMail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("userMail")
                    .IsFixedLength(true);

                entity.Property(e => e.UserNameSurname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("userNameSurname")
                    .IsFixedLength(true);

                entity.Property(e => e.UserPhone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("userPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.UserRole)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("userRole")
                    .IsFixedLength(true);

                entity.Property(e => e.UserTcNo)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("userTcNo")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
