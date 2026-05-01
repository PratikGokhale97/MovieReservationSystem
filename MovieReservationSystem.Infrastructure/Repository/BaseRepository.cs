using Microsoft.EntityFrameworkCore;
using MovieReservationSystem.Domain.Interfaces;
using MovieReservationSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Infrastructure.Repository
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		protected readonly AppDbContext _context;

		protected readonly DbSet<T> _dbSet;

		public BaseRepository(AppDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var entity = await _dbSet.FindAsync(id);
			if(entity != null)
			{
				 _dbSet.Remove(entity);
			}
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T?> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		//Update is not async because it does not involve any I/O operation,
		//it just marks the entity as modified in the context.
		//The actual database update happens when SaveChangesAsync is called, which is where the async operation occurs.
		public Task UpdateAsync(T entity)  										   										   
		{
			 _dbSet.Update(entity);
			return Task.CompletedTask;
		}

		//Remember methods are marked async only if it hits the db or any I/O operation, otherwise it should be a normal method.
		//here remove/add/update dont require async but since find delete uses findasync and add generates ids so dbs is hit but update only marks 
		//eneity has changed in ef core change tracker
		//actual query execution happens when savechangesasync is called in unitofwork

	}
}
