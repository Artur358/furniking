using Furniking.BLL.DTOs.CategoryDTOs;
using Furniking.BLL.DTOs.ImageDTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.DTOs.FurnitureDTOs
{
    public class CreateFurnitureDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        
        public ImageDTO MainImage { get; set; }

        
        public IList<ImageDTO>? Galery { get; set;}



    }
}
