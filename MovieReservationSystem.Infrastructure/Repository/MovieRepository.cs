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
	public class MovieRepository : BaseRepository<Movie>, IMovieRepository
	{
		//No need to declare appdbcontext here when movierepos is created appdbcontext is create in parent and passed to child
		//

		public MovieRepository(AppDbContext context): base(context) {}


		public async Task<Movie?> GetMovieByNameAsync(string name)
		{
			return await _dbSet.Where(m => m.MovieName == name).FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<Movie>> GetMoviesByDatesAsync(DateTime date)
		{
			return await _dbSet.Include(m => m.ShowTimes)
				.Where(m => m.ShowTimes.Any(st => st.StartTime == date)).ToListAsync();
		}

		public async Task<IEnumerable<Movie>> GetMoviesByGenresAsync(int genreId)
		{
			return await _dbSet.Where(m => m.MovieGenres.Any(mg => mg.GenreId == genreId)).ToListAsync();			
		}

		public async Task<IEnumerable<Movie>> GetMoviesByShowtimeAsync(int showtimeId)
		{
			return await _dbSet.Where(m => m.ShowTimes.Any(st => st.ShowTimeId == showtimeId)).ToListAsync();
		}
	}
}
