using Api.Models.Domain;
using Api.Repositories;
using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Api.Controllers;

[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
[ApiVersion("1.0")]
public class BlogPostsController : ControllerBase
{
    private readonly IBlogPostRepository blogPostRepository;
    private readonly IMapper mapper;

    public BlogPostsController(IBlogPostRepository blogPostRepository, IMapper mapper)
    {
        this.blogPostRepository = blogPostRepository;
        this.mapper = mapper;
    }

    [HttpGet]
    [MapToApiVersion("1.0")]
    public async Task<IActionResult> GetAllV1()
    {
        var blogPosts = await blogPostRepository.GetAllAsync();
        return Ok(mapper.Map<List<BlogPostDtoV1>>(blogPosts));
    }
}