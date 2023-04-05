using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
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


    }
}
