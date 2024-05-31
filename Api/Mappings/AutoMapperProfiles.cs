using Api.Models.Domain;
using AutoMapper;

namespace Api.Mappings;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<BlogPost, BlogPostDtoV1>().ReverseMap();
        CreateMap<Tag, TagDtoV1>().ReverseMap();
    }
}