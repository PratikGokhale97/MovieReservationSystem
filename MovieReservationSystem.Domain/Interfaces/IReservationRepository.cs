using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Interfaces
{
	public interface IReservationRepository : IBaseRepository<Reservation> 
	{
		//Get reservation for a user
		Task<IEnumerable<Reservation>> GetReservationByUserIdAsync(int userid);

		//Get reservation for a specific showtime
		Task<IEnumerable<Reservation>> GetReservationByShowtimeIdAsync(int showtimeId);

		//get reservation which are cancelled for a specific showtime
		Task<IEnumerable<Reservation>> GetCancelledReservationsByShowtimeIdAsync(int showtimeId);

		//Get reservation by screen id
		Task<IEnumerable<Reservation>> GetReservationsByScreenIdAsync(int screenId);

		//Get reservation by movie id
		Task<IEnumerable<Reservation>> GetReservationsByMovieIdAsync(int movieId);


	}
}
