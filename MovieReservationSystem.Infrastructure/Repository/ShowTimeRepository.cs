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
			return await _dbSet.Where(st => st.StartTime == date).ToListAsync();
		}
		public async Task<IEnumerable<ShowTime>> GetShowTimesByMovieIdAsync(int movieId)
		{
			return await _dbSet.Where(st => st.MovieId == movieId).ToListAsync();
		}
		public async Task<IEnumerable<ShowTime>> GetShowTimesByScreenIdAsync(int screenId)
		{
			return await _dbSet.Where(st => st.ScreenId == screenId).ToListAsync();
		}
		public async Task<IEnumerable<ShowTimePricing>> GetShowTimePricingByShowTimeIdAsync(int showTimeId) 
		{ 
			return await _context.ShowTimePricings.Where(st => st.ShowTimeId == showTimeId).ToListAsync();
		}
		
	}
}
