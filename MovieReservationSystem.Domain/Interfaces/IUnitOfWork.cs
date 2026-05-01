using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		//Only get because we will not set the repositories from outside the unit of work
		IMovieRepository Movies { get; }
		IGenreRepository Genres { get; }
		IReservationRepository Reservations { get; }
		IUserRepository Users { get; }
		ISeatRepository Seats { get; }
		IShowTimeRepository ShowTimes { get; }
		ITheatreRepository Theatres { get; }

		Task<int> SaveChangesAsync();

		Task BeginTransactionAsync();

		Task CommitTransactionAsync();

		Task RollbackTransactionAsync();
		
	}
}
