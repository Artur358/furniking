using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime date { get; set; }

        public int Count { get; set; }

        public int FurnitureId { get; set; }
        public Furniture Furniture { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }

    }
}
