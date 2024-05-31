using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Api.Controllers;

[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
[ApiVersion("1.0")]
public class BlogPostsController : ControllerBase
{
    public BlogPostsController()
    {
        
    }

    [HttpGet]
    [MapToApiVersion("1.0")]
    public async Task<IActionResult> GetAllV1()
    {

        return Ok();
    }
}