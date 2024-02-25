using System.Collections.Generic; // Добавлено пространство имён

using Domain.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channel>()
                .HasMany(c => c.Items)
                .WithOne(i => i.Channel)
                .HasForeignKey(i => i.IdChannel);

            modelBuilder.Entity<Channel>()
                .HasMany(c => c.Categories)
                .WithMany(c => c.Channels);

            modelBuilder.Entity<Channel>()
                .HasOne(c => c.Cloud)
                .WithMany(c => c.Channels)
                .HasForeignKey(c => c.IdCloud);

            modelBuilder.Entity<Channel>()
                .HasOne(c => c.Image)
                .WithMany(c => c.Channels)
                .HasForeignKey(c => c.IdImage);

            modelBuilder.Entity<Channel>()
                .HasOne(c => c.TextInput)
                .WithMany(c => c.Channels)
                .HasForeignKey(c => c.IdTextInput);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.Channel)
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.IdChannel);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.Categories)
                .WithMany(c => c.Items);

            modelBuilder.Entity<Item>()
                .HasOne(c => c.Enclosure)
                .WithMany(c => c.Items)
                .HasForeignKey(c => c.IdEnclosure);

            modelBuilder.Entity<Item>()
                .HasOne(c => c.Guid)
                .WithMany(c => c.Items)
                .HasForeignKey(c => c.IdGuid);

            modelBuilder.Entity<Item>()
                .HasOne(c => c.Source)
                .WithMany(c => c.Items)
                .HasForeignKey(c => c.IdSource);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Cloud> Clouds { get; set; }
        public DbSet<Enclosure> Enclosures { get; set; }
        public DbSet<Domain.Models.Database.Guid> Guids { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<TextInput> TextInputs { get; set; }
    }
}
