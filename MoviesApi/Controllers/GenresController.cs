using Microsoft.AspNetCore.Mvc;
using MoviesApi.Entities;
using MoviesApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Controllers
{
    [Route("api/genres")]
    public class GenresController:ControllerBase
    {
        private readonly IRepository _repository;
        public GenresController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public List<Genre> Get()
        {
            return _repository.GetAllGenres();
        }
       

        [HttpGet]

        public Genre GetGenreById(int id)
        {
            var genre = _repository.GetGenreById(id);
            if(genre == null)
            {
                //return NotFound();
            }
            return genre;
        }
    }
}
