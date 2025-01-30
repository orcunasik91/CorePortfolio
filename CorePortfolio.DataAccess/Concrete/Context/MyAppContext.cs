using CorePortfolio.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CorePortfolio.DataAccess.Concrete.Context;
public class MyAppContext : IdentityDbContext<AppUser, AppUserRole, int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=CorePortfolioDb;User ID=sa;Password=Password1;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AppUser>(entity =>
        {
            entity.ToTable("AspNetUsers");
            entity.Property(e => e.FirstName).HasMaxLength(50).IsRequired(false);
            entity.Property(e => e.LastName).HasMaxLength(50).IsRequired(false);
            entity.Property(e => e.ImageUrl).HasMaxLength(250).IsRequired(false);
        });
        builder.Entity<AppUserRole>(entity =>
        {
            entity.ToTable("AspNetRoles");
        });
        builder.Entity<IdentityUserClaim<int>>().ToTable("AspNetUserClaims");
        builder.Entity<IdentityUserLogin<int>>().ToTable("AspNetUserLogins");
        builder.Entity<IdentityUserToken<int>>().ToTable("AspNetUserTokens");
        builder.Entity<IdentityRoleClaim<int>>().ToTable("AspNetRoleClaims");
        builder.Entity<IdentityUserRole<int>>().ToTable("AspNetUserRoles");
    }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<MyService> MyServices { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<ToDoList> ToDoLists { get; set; }
}