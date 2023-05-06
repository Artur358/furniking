using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Entities
{
    public class FurnitureGalery : BaseEntity
    {
        public int FurnitureId { get; set; }
        public virtual Furniture Furniture { get; set; }

        public int ImageId { get; set; }
        public virtual Image Image { get; set; }

    }
}
