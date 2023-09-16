using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesApi.DTOs;
using MoviesApi.Entities;
using MoviesApi.Filters;
using MoviesApi.Helpers;
using MoviesApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Controllers
{
    [Route("api/genres")]
    //[ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenresController : ControllerBase
    {

        private readonly ILogger<GenresController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GenresController(ILogger<GenresController> logger, ApplicationDbContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<GenreDTO>>> Get([FromBody] PaginationDTO paginationDTO)
        {
            _logger.LogInformation("Getting All the Genres");
            var queryable = _context.Genres.AsQueryable();
            await HttpContext.InsertParametersPaginationInHeader(queryable);
            var genres = await queryable.OrderBy(x=>x.Name).Paginate(paginationDTO).ToArrayAsync();
            return _mapper.Map<List<GenreDTO>>(genres);
            //var genres =  await _context.Genres.ToListAsync();

            //var genreDTOs = new List<GenreDTO>();
            //foreach (var genre in genres) 
            //{
            //    genreDTOs.Add(new GenreDTO { Id= genre.Id, Name= genre.Name });
            
            //}
            //return genreDTOs;
        }

        //api/genres
        //[HttpGet("list")]//api/genres/list
        //[HttpGet("/allgenres")]//allgenres
        //[ResponseCache(Duration =60)]
        //[ServiceFilter(typeof(MyActionFilter))]
        //public async Task<IActionResult> Get()
        //{
        //    //var allData = await _repository.GetAllGenres();


        //    //if(allData == null)
        //    //{
        //    //    _logger.LogWarning("Genres All Data Not Found");
        //    //    return NotFound();
        //    //}
        //    _logger.LogInformation("Getting All the Genres");
        //    return Ok(allData);
        //}




        //[HttpGet("{id}")]

        //[HttpGet("Id:int/{param2=felipe}")]
        //public IActionResult GetGenreById(int id)
        //{

        //    _logger.LogDebug("Get By Id Method Excuted");
        //    var genre = _repository.GetGenreById(id);
        //    if(genre == null)
        //    {
        //        _logger.LogWarning($"Genre with ID {id} not found");
        //        _logger.LogError("This is an Error");
        //        return NotFound();
        //    }
        //    return Ok(genre);
        //}

        [HttpGet("{Id:int}")]
        public  ActionResult<Genre> Get( int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GenreCreationDTO genreCreationDTO)
        {
            var genre = _mapper.Map<Genre>(genreCreationDTO);
            _context.Add(genre);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut]
        public ActionResult Put([FromBody] Genre genre) {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
