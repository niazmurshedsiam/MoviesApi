using Microsoft.Extensions.Logging;
using MoviesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Services
{
    public class InMemoryRepository : IRepository
    {
        private List<Genre> _genres;
        private readonly ILogger _logger;
        public InMemoryRepository(ILogger<InMemoryRepository> logger)
        {
            _genres = new List<Genre>() {
            new Genre() { Id=1,Name="Comedy"},
            new Genre() { Id=2,Name="Action"},
            };
            _logger = logger;
        }

        public async Task<List<Genre>> GetAllGenres()
        {
            _logger.LogInformation("Excecute Get All Genres");
            await Task.Delay(3000);
            return _genres;
        }



        public Genre GetGenreById(int id)
        {
            return _genres.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
