using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;

namespace Furniking.DAL.Repositories.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataContext dbContext) : base(dbContext)
        { }
    }
}
