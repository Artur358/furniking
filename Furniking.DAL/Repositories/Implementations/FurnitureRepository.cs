using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Repositories.Implementations
{
    public class FurnitureRepository : Repository<Furniture>, IFurnitureRepository
    {

        public FurnitureRepository(DataContext db)
            : base(db)
        {
        }

        public async Task<IList<Furniture>> GetPageAsync(int page, int page_size)
        {
            return await _dbContext.Furnitures.Skip((page-1) * page_size).Take(page_size).ToListAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _dbContext.Furnitures.CountAsync();
        }

        //public async IAsyncEnumerable<Furniture> GetPage(int page, int page_size)
        //{
        //    var pageList = _dbContext.Furnitures.Skip((page - 1) * page_size).Take(page_size).AsAsyncEnumerable();

        //    await foreach (var item in pageList)
        //    {
        //        yield return item;
        //    }

        //}
    }
}
