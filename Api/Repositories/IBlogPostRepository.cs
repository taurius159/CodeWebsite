using System.Runtime.InteropServices;
using Api.Models.Domain;

namespace Api.Repositories;
public interface IBlogPostRepository
{
    Task<BlogPost> CreateAsync(BlogPost walk);

    Task<List<BlogPost>> GetAllAsync(string? filterOn = null, string? filterQuery = null, 
    string? sortBy = null, bool isAscending = true,
    int pageNumber = 1, int pageSize = 1000);
    Task<BlogPost?> GetByIdAsync(Guid id);
    Task<BlogPost?> UpdateAsync(Guid id, BlogPost walk);
    Task<BlogPost?> DeleteAsync(Guid id);
}