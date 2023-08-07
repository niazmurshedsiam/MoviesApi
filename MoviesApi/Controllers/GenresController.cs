using Microsoft.AspNetCore.Mvc;
using MoviesApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Controllers
{
    public class GenresController : Controller
    {
        private readonly IRepository _repository;
        public GenresController( IRepository repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
