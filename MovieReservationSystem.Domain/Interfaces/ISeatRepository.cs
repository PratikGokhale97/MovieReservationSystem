using System.Threading.Tasks;
using System.Collections.Generic;
using MovieReservationSystem.Domain.Entities;

namespace MovieReservationSystem.Domain.Interfaces
{
	public interface ISeatRepository : IBaseRepository<Seat>
	{
		//get seats by screen id
		Task<IEnumerable<Seat>> GetSeatsByScreenIdAsync(int screenId);

		//get available seats by screen id
		Task<IEnumerable<Seat>> GetAvailableSeatsByScreenIdAsync(int showTimeId);
	}
}
