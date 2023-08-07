﻿using MoviesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Services
{
    public class InMemoryRepository : IRepository
    {
        private List<Genre> _genres;
        public InMemoryRepository()
        {
            _genres = new List<Genre>() {
            new Genre() { Id=1,Name="Comedy"},
            new Genre() { Id=2,Name="Action"},
            };
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }



        public Genre GetGenreById(int id)
        {
            return _genres.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
