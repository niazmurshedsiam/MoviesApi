using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Services
{
    
    public interface IRepository
    {
        Task<List<Genre>> GetAllGenres();
        public Genre GetGenreById(int id);
    }
}
