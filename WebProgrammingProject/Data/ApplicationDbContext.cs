using Microsoft.EntityFrameworkCore;
using WebProgrammingProject.Modeller; // Modeller namespace'ini eklediğinizden emin olun

namespace WebProgrammingProject.Data // Data klasörünüzün namespace'ini kontrol edin
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Veritabanı tablolarını temsil eden DbSet'ler
        public DbSet<Salon> Salons { get; set; } // Salon tablosu
        public DbSet<Worker> Workers { get; set; } // Worker tablosu

        // Model yapılandırmaları
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Salon ve Worker arasındaki ilişki
            modelBuilder.Entity<Worker>()
                .HasOne(w => w.Salon) // Worker bir Salon'a ait
                .WithMany(s => s.Workers) // Salon birden fazla Worker'a sahip
                .HasForeignKey(w => w.SalonId) // Worker'ın SalonId'si yabancı anahtar
                .OnDelete(DeleteBehavior.Cascade); // Salon silindiğinde çalışanlar da silinsin
        }
    }
}
