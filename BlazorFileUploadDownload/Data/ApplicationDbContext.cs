using BlazorFileUploadDownload.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorFileUploadDownload.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 1,
                Nome = "Assassin's Creed",
                Preco = 135

            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 2,
                Nome = "FallOut 4",
                Preco = 155,

            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 3,
                Nome = "BordeLands",
                Preco = 195,

            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 4,
                Nome = "Duke Nukem",
                Preco = 58,

            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 5,
                Nome = "Maria Cart Deluxe 8",
                Preco = 350,

            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 6,
                Nome = "Castlevania",
                Preco = 35,

            });
        }
    }
}
