using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalJwt.Models;
using MinimalJwt.Repositories;
using MinimalJwt.Services;

namespace MinimalJwt.Controllers
{
    [Route("[controller]")]
    [ApiController]


    public class ListController : Controller
    {
        private readonly IMovieService _movieService;
        public ListController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]

        [ProducesResponseType(200, Type = typeof(Movie))]

       

        public IResult List(IMovieService service)
        {
            var movies = service.List();

            return Results.Ok(movies);
        }
    }
}
