using Api.Data;
using Api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories;
public class SQLBlogPostRepository : IBlogPostRepository
{
    private readonly CodeWebsiteDbContext dbContext;

    public SQLBlogPostRepository(CodeWebsiteDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<BlogPost>> GetAllAsync(string? filterOn = null, 
    string? filterQuery = null, string? sortBy = null, bool isAscending = true, 
    int pageNumber = 1, int pageSize = 1000)
    {
        var blogPosts = dbContext.BlogPosts
            .Include(x => x.Tags)
            .AsQueryable();

        // Filtering

        // Sorting

        // Pagination
        var skipResults = (pageNumber-1) * pageSize;

        return await blogPosts.Skip(skipResults).Take(pageSize).ToListAsync();
    }

    public Task<BlogPost?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<BlogPost> CreateAsync(BlogPost walk)
    {
        throw new NotImplementedException();
    }

    public Task<BlogPost?> UpdateAsync(Guid id, BlogPost walk)
    {
        throw new NotImplementedException();
    }

    public Task<BlogPost?> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
