using Api.Data;
using Api.Mappings;
using Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add db context
builder.Services.AddDbContext<CodeWebsiteDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("CodeWebsiteConnectionString")));

// Add api versioning
builder.Services.AddApiVersioning();

// Add SQLBlogPostRepository
builder.Services.AddScoped<IBlogPostRepository, SQLBlogPostRepository>();

// Add auto mapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
