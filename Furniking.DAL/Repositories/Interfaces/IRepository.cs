﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Repositories.Interfaces
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T?> GetByIdAsync(int id);
		Task<T> AddAsync(T entity);
		Task<bool> DeleteByIdAsync(int id);
		Task<T> UpdateAsync(T entity);
		Task SaveChangesAsync();

		Task<T> AddAsync(T entity, params Expression<Func<T, object>>[] includeProperties);

    }
}
