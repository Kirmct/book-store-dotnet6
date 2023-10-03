using BookStoreApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Infra.Data.Context
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {}

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookContext).Assembly);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("sua_string_de_conexao",
        //b => b.MigrationsAssembly("BookStoreApp.Infra.Data"));
        //}
    }
}
