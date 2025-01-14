using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace mybookapp.Models
{
    public class MyBookAppContext : IdentityDbContext<IdentityUser>
    {
        public MyBookAppContext(DbContextOptions<MyBookAppContext> options)
        : base(options)

        { }

        public DbSet<User>? Users { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Author>? Authors { get; set; }
        public DbSet<UserBook>? UserBooks { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<CategoryBook>? CategoryBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure StudentCourse as a join entity
            modelBuilder.Entity<CategoryBook>()
                .HasKey(sc => new { sc.CategoryId, sc.BookId });

            // Configure many-to-many relationship between Student and Course
            modelBuilder.Entity<CategoryBook>()
                .HasOne<Category>(sc => sc.Category)
                .WithMany(s => s.Books)
                .HasForeignKey(sc => sc.CategoryId);

            modelBuilder.Entity<CategoryBook>()
                .HasOne<Book>(sc => sc.Book)
                .WithMany(c => c.Categories)
                .HasForeignKey(sc => sc.CategoryId);
        }
    }
}
