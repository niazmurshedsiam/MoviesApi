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
    [ApiController]
    public class GenresController:ControllerBase
    {
        private readonly IRepository _repository;
        public GenresController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]//api/genres
        //[HttpGet("list")]//api/genres/list
        //[HttpGet("/allgenres")]//allgenres
        public IActionResult Get()
        {
            var allData = _repository.GetAllGenres();

            if(allData == null)
            {
                return NotFound();
            }
            return Ok(allData);
        }
       

        [HttpGet("{id}")]

        //[HttpGet("Id:int/{param2=felipe}")]
        public IActionResult GetGenreById(int id)
        {
            var genre = _repository.GetGenreById(id);
            if(genre == null)
            {
                return NotFound();
            }
            return Ok(genre);
        }
    }
}
