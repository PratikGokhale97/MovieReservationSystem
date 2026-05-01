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
	public class SeatRepository : BaseRepository<Seat> , ISeatRepository
	{
		public SeatRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Seat>> GetAvailableSeatsByScreenIdAsync(int showTimeId)
		{
			var reservedseatsIds = await _context.ReservationSeats.Where(rs => rs.ShowTimeId == showTimeId).Select(rs => rs.SeatId).ToListAsync();

			var showtimes = await _context.ShowTimes.FindAsync(showTimeId);

			return await _dbSet.Where(s => s.ScreenId == showtimes.ScreenId && !reservedseatsIds.Contains(s.SeatId)).ToListAsync();
		}

		public async Task<IEnumerable<Seat>> GetSeatsByScreenIdAsync(int screenId)
		{
			return await _dbSet.Where(s => s.ScreenId == screenId).ToListAsync();
		}
	}
}
