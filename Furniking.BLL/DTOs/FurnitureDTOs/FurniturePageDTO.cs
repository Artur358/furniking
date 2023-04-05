using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.DTOs.FurnitureDTOs
{
    public class FurniturePageDTO
    {
        public int TotalCount { get; set; }
        public int PageCount { get; set; }
        public ICollection<FurnitureDTO> Furnitures { get; set; }
    }
}
