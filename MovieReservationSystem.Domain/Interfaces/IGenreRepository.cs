using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Interfaces
{
	public interface IGenreRepository : IBaseRepository<Genre>
	{
		//Get genre by movie id
		Task<IEnumerable<Genre>> GetGenresByMovieIdAsync(int movieId);

	}
}
