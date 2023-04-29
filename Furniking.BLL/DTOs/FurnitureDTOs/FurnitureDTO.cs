using Furniking.BLL.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.DTOs.FurnitureDTOs
{
    public class FurnitureDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public decimal Price { get; set; }
        public CategoryInfoDTO Category { get; set; }

        public int MainImageId { get; set; }

        public ICollection<int> Galery { get; set; }
        public ICollection<int> ReviewsId { get; set; }

    }
}
