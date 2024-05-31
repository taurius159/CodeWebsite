using Api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class CodeWebsiteDbContext : DbContext
{
    public CodeWebsiteDbContext(DbContextOptions<CodeWebsiteDbContext> dbContextOptions) :base(dbContextOptions)
    {
        
    }

    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}