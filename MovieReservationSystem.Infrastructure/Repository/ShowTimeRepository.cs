using Microsoft.EntityFrameworkCore;
using MovieReservationSystem.Domain.Entities;
using MovieReservationSystem.Domain.Interfaces;
using MovieReservationSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MovieReservationSystem.Infrastructure.Repository
{
	public  class ShowTimeRepository : BaseRepository<ShowTime>, IShowTimeRepository
	{
		public ShowTimeRepository(AppDbContext context) : base(context) { }
		public async Task<IEnumerable<ShowTime>> GetShowTimesByDateAsync(DateTime date)
		{
			return await _dbSet.Where(st => st.StartTime.Date == date.Date).ToListAsync();
		}
		public async Task<IEnumerable<ShowTime>> GetShowTimesByMovieIdAsync(int movieId)
		{
			return await _dbSet.Where(st => st.MovieId == movieId).ToListAsync();
		}
		public async Task<IEnumerable<ShowTime>> GetShowTimesByScreenIdAsync(int screenId)
		{
			return await _dbSet.Where(st => st.ScreenId == screenId).ToListAsync();
		}

		//Below method is not needed as we can get the pricing details with showtime details in one query using
		//include method in ef core, so we can remove this method and use the below method to get showtime with pricing details in one query.
		//public async Task<IEnumerable<ShowTimePricing>> GetShowTimePricingByShowTimeIdAsync(int showTimeId) 
		//{ 
		//	return await _context.ShowTimePricings.Where(st => st.ShowTimeId == showTimeId).ToListAsync();
		//}

		public async Task<ShowTime?> GetShowTimeWithPricingAsync(int showTimeId)
		{
			return await _dbSet.Include(s => s.ShowTimePricing)
				.FirstOrDefaultAsync(s => s.ShowTimeId == showTimeId);
		}
	}
}
