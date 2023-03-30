using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Entities
{
    public class Furniture
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public IList<Image> Images { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        

        // ... 

    }
}
