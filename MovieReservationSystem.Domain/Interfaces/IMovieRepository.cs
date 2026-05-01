using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Interfaces
{
	public interface IMovieRepository : IBaseRepository<Movie>
	{
		//With Movie we can gemoview by genres

		Task<IEnumerable<Movie>> GetMoviesByGenresAsync(int genreId);

		//get movie by showtimes
		Task<IEnumerable<Movie>> GetMoviesByShowtimeAsync(int showtimeId);
		//getmoviesby names

		Task<Movie?> GetMovieByNameAsync(string name);

		//getmovies by dates

		Task<IEnumerable<Movie>> GetMoviesByDatesAsync(DateTime date);

	}

}
