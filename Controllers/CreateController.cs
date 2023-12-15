using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalJwt.Models;
using MinimalJwt.Services;

namespace MinimalJwt.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CreateController : Controller
    {
        private readonly IMovieService _movieService;
        public CreateController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
      


        IResult Create(Movie movie, IMovieService service)
        {
            var result = service.Create(movie);
            return Results.Ok(result);
        }
    

    //public IActionResult Create([FromBody] Movie movie)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var createdMovie = _movieService.Create(movie);

    //        if (createdMovie != null)
    //        {
    //            // Assuming your IMovieService returns the created movie upon success
    //            return Ok(createdMovie);
    //        }
    //        else
    //        {
    //            // You can customize the response for failure if needed.
    //            return BadRequest("Failed to create movie");
    //        }
    //    }
    }
}
