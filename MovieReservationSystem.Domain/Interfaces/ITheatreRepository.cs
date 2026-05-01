using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Interfaces
{
	public interface ITheatreRepository : IBaseRepository<Theatre>
	{ 
		//get Theatre by city
		Task<IEnumerable<Theatre>> GetTheatresByCityAsync(string city);

		//get all screens in a theatre
		Task<IEnumerable<Screen>> GetScreensByTheatreIdAsync(int theatreId);

	}
}
