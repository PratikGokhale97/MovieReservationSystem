using MovieReservationSystem.Domain.Entities;
using MovieReservationSystem.Domain.Interfaces;
using MovieReservationSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
namespace MovieReservationSystem.Infrastructure.Repository
{
	public class ReservationRepository : BaseRepository<Reservation> , IReservationRepository
	{
		public ReservationRepository(AppDbContext context) : base(context) { }

		public async Task<IEnumerable<Reservation>> GetCancelledReservationsByShowtimeIdAsync(int showtimeId)
		{
			return await _dbSet.Where(r => r.ShowTimeId == showtimeId && r.BookingStatus == BookingStatus.Cancelled).ToListAsync();
		}

		public async Task<IEnumerable<Reservation>> GetReservationByShowtimeIdAsync(int showtimeId)
		{
			return await _dbSet.Where(r => r.ShowTimeId == showtimeId).ToListAsync();
		}

		public async Task<IEnumerable<Reservation>> GetReservationByUserIdAsync(int userid)
		{
			return await _dbSet.Where(r => r.UserId == userid).ToListAsync();
		}

		public async Task<IEnumerable<Reservation>> GetReservationsByMovieIdAsync(int movieId)
		{
			return await _dbSet.Where(r => r.ShowTime.MovieId == movieId).ToListAsync();
		}

		public async Task<IEnumerable<Reservation>> GetReservationsByScreenIdAsync(int screenId)
		{
			return await _dbSet.Where(r => r.ShowTime.ScreenId == screenId).ToListAsync();
		}
	}
}
