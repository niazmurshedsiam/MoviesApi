using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesApi.Entities;
using MoviesApi.Filters;
using MoviesApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Controllers
{
    [Route("api/genres")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenresController:ControllerBase
    {
        private readonly IRepository _repository;
        private readonly ILogger<GenresController> _logger;
        public GenresController(IRepository repository, ILogger<GenresController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]//api/genres
        //[HttpGet("list")]//api/genres/list
        //[HttpGet("/allgenres")]//allgenres
        //[ResponseCache(Duration =60)]
        [ServiceFilter(typeof(MyActionFilter))]
        public async Task<IActionResult> Get()
        {
            var allData = await _repository.GetAllGenres();
            

            if(allData == null)
            {
                _logger.LogWarning("Genres All Data Not Found");
                return NotFound();
            }
            _logger.LogInformation("Getting All the Genres");
            return Ok(allData);
        }
       

        [HttpGet("{id}")]

        //[HttpGet("Id:int/{param2=felipe}")]
        public IActionResult GetGenreById(int id)
        {

            _logger.LogDebug("Get By Id Method Excuted");
            var genre = _repository.GetGenreById(id);
            if(genre == null)
            {
                _logger.LogWarning($"Genre with ID {id} not found");
                _logger.LogError("This is an Error");
                return NotFound();
            }
            return Ok(genre);
        }
    }
}
