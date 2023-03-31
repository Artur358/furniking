using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Entities
{
    public class Order : BaseEntity
    {
        public DateTime date { get; set; }

        public int Count { get; set; }

        public int FurnitureId { get; set; }
        public virtual Furniture Furniture { get; set; }


        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
