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
	public class GenreRepository : BaseRepository<Genre> , IGenreRepository
	{
		public GenreRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Genre>> GetGenresByMovieIdAsync(int movieId)
		{
			return await _dbSet.Where(g => g.MovieGenres.Any(mg => mg.MovieId == movieId)).ToListAsync();
		}

		
	}
}
