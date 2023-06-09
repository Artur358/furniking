﻿using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Repositories.Implementations
{
	public class Repository<T> : IRepository<T> where T : class, IBaseEntity
	{
		protected readonly DataContext _dbContext;
		private readonly DbSet<T> _dbSet;

		public Repository(DataContext dbContext)
		{
			_dbContext = dbContext;
			_dbSet = _dbContext.Set<T>();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T?> GetByIdAsync(int id)
		{			
			return await _dbSet.FindAsync(id);
		}

		public async Task<T> AddAsync(T entity)
		{
			var r = await _dbSet.AddAsync(entity);
			await SaveChangesAsync();
			return r.Entity;
		}

        public async Task<T> AddAsync(T entity, params Expression<Func<T, object>>[] includeProperties)
        {
            var addedEntity = await _dbSet.AddAsync(entity);
            await SaveChangesAsync();

            foreach (var includeProperty in includeProperties)
            {
                await _dbContext.Entry(addedEntity.Entity).Reference(includeProperty).LoadAsync();
            }

            
            return addedEntity.Entity;
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

		public IQueryable<T> GetQueryable()
		{
			return _dbSet.AsQueryable();
		}


        public async Task SaveChangesAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
	}
}
