using Microsoft.EntityFrameworkCore;
using MovieReservationSystem.Domain.Entities;
using MovieReservationSystem.Domain.Interfaces;
using MovieReservationSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Infrastructure.Repository
{
	public class TheatreRepository : BaseRepository<Theatre>, ITheatreRepository
	{
		public TheatreRepository(AppDbContext context) : base(context) { } 

		public async Task<IEnumerable<Screen>> GetScreensByTheatreIdAsync(int theatreId)
		{
			return await _context.Screens.Where(s => s.TheatreId == theatreId).ToListAsync();
		}

		public async Task<IEnumerable<Theatre>> GetTheatresByCityAsync(string city)
		{
			return await _dbSet.Where(t => t.Address.City == city).ToListAsync();
		}

		
	}
}
