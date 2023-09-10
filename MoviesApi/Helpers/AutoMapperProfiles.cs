using AutoMapper;
using MoviesApi.DTOs;
using MoviesApi.Entities;

namespace MoviesApi.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles() { 
        CreateMap<GenreDTO, Genre>().ReverseMap();
        }
    }
}
