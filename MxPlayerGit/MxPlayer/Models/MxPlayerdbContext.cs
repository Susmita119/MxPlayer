using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MxPlayer.Models

{
    public partial class MxPlayerdbContext : DbContext
    {
        public MxPlayerdbContext()
        {
        }

        public MxPlayerdbContext(DbContextOptions<MxPlayerdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SongsTable> SongsTable { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-FU798E3\\SQLEXPRESS;Initial Catalog=MxPlayerdb;User ID=sa;Password=Test_1234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongsTable>(entity =>
            {
                entity.Property(e => e.SongName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
