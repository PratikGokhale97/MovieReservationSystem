using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieReservationSystem.Infrastructure.Data;

namespace MovieReservationSystem.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MovieController : ControllerBase
	{
		private readonly AppDbContext _context;


		public MovieController(AppDbContext context)
		{
			_context = context;
		}

		


	}
}
