using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Interfaces
{
	public interface IShowTimeRepository : IBaseRepository<ShowTime>
	{
		//Get showtimes by movie id
		Task<IEnumerable<ShowTime>> GetShowTimesByMovieIdAsync(int movieId);
		//Get showtimes by screen id
		Task<IEnumerable<ShowTime>> GetShowTimesByScreenIdAsync(int screenId);
		//Get showtimes by date
		Task<IEnumerable<ShowTime>> GetShowTimesByDateAsync(DateTime date);

		//Get showtimepricing for a showtime
		Task<IEnumerable<ShowTimePricing>> GetShowTimePricingByShowTimeIdAsync(int showTimeId);

	}
}
