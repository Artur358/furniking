using Furniking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Repositories.Interfaces
{
	public interface IFurnitureRepository : IRepository<Furniture>
	{
		Task<IList<Furniture>> GetPageAsync(int page, int page_size);
		Task<int> CountAsync();

	}
}