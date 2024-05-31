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

        //seed tags
        var tags = new List<Tag>()
        {
            new Tag
            {
                Id = Guid.Parse("5035a2a2-54f1-4e6a-81b6-40e0b589f637"),
                Name = "Review",
                DisplayName = "Review"
            },
            new Tag
            {
                Id = Guid.Parse("dad9b2fa-3bb1-4dde-97f9-e2f6e0dc949b"),
                Name = "Guide",
                DisplayName = "Guide"
            },
            new Tag
            {
                Id = Guid.Parse("2fa42358-a83b-412d-8048-c2356e8ccb2a"),
                Name = "Projects",
                DisplayName = "Projects"
            }
        };
        modelBuilder.Entity<Tag>().HasData(tags);

        //seed blog posts
        var blogPosts = new List<BlogPost>()
        {
            new BlogPost
            {
                Id = Guid.Parse("a200b634-e8ca-46e8-9c38-def3595b940b"),
                Heading = "API MVC course Review",
                PageTitle = "Best intermediate programmer API course",
                Content = "",
                ShortDescription = "",
                FeaturedImageUrl = "",
                UrlHandle = "",
                PublishedDate = DateTime.Now,
                Author = "Taurius Antanevicius",
                Visible = true
            }
        };
        modelBuilder.Entity<BlogPost>().HasData(blogPosts);
    }
}