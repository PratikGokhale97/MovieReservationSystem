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
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(AppDbContext context) : base(context) { }
		public async Task<User?> GetUserByEmailAsync(string email)
		{
			return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
		}
	}
}
