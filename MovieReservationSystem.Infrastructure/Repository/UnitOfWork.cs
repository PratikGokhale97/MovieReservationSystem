using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using MovieReservationSystem.Domain.Interfaces;
using MovieReservationSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Infrastructure.Repository
{
	public  class UnitOfWork : IUnitOfWork
	{		
		private readonly AppDbContext _context;
		private IMovieRepository? _movies;
		private IGenreRepository? _genres;
		private IReservationRepository? _reservations;
		private IUserRepository? _users;
		private ISeatRepository? _seats;
		private IShowTimeRepository? _showTimes;
		private ITheatreRepository? _theatres;
		private bool _disposed = false;
		private IDbContextTransaction? _transaction;

		public UnitOfWork(AppDbContext context)
		{
			_context = context;		
		}

		public IMovieRepository Movies =>
			_movies ??= new MovieRepository(_context);


		public IGenreRepository Genres => 
			_genres??= new GenreRepository(_context);

		public IReservationRepository Reservations =>
			_reservations ??= new ReservationRepository(_context);

		public IUserRepository Users =>
			_users ??= new UserRepository(_context);

		public ISeatRepository Seats =>
			_seats ??= new SeatRepository(_context);

		public IShowTimeRepository ShowTimes =>
			_showTimes ??= new ShowTimeRepository(_context);

		public ITheatreRepository Theatres =>
			_theatres ??= new TheatreRepository(_context);

		public async Task<int> SaveChangesAsync()
		{
			return await _context.SaveChangesAsync();
		}

		public async Task BeginTransactionAsync()
		{
			_transaction = await _context.Database.BeginTransactionAsync();
		}

		public async Task CommitTransactionAsync()
		{
			if(_transaction != null)
				await _transaction.CommitAsync();
			
		}

		public async  Task RollbackTransactionAsync()
		{
			if (_transaction != null)
				await _transaction.RollbackAsync();
		}

		//There is no need to implement below methods because appdbcontext is already being injected and will be disposed by the DI container.
		//But we can implement it for the sake of completeness and to follow the IDisposable pattern.
		public void Dispose()
		{			
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					_context?.Dispose();
					_transaction?.Dispose();
				}
				_disposed = true;
			}
		}
	}
}
