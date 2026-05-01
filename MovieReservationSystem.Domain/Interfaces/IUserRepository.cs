using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Interfaces
{
	public interface IUserRepository : IBaseRepository<User> 
	{
		//Get user by email
		Task<User?> GetUserByEmailAsync(string email);

	}
}
