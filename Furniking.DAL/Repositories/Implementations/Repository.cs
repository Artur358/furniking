using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Furniking.DAL.Repositories.Implementations
{
	public class Repository<T> : IRepository<T> where T : class, IBaseEntity
	{
		protected readonly DataContext _dbContext;
		protected readonly DbSet<T> _dbSet;

		public Repository(DataContext dbContext)
		{
			_dbContext = dbContext;
			_dbSet = _dbContext.Set<T>();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task<T> AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
			await SaveChangesAsync();
			return entity;
		}

		public async Task<bool> DeleteByIdAsync(int id)
		{
			var entity = await GetByIdAsync(id);
			if (entity != null)
			{
				_dbSet.Remove(entity);
				await SaveChangesAsync();
				return true;
			}
			return false;
		}

		public async Task<T> UpdateAsync(T entity)
		{
			_dbSet.Update(entity);
			await SaveChangesAsync();
			return entity;

		}

		public async Task SaveChangesAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
	}
}
