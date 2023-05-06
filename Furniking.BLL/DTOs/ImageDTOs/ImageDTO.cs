using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.DTOs.ImageDTOs
{
    public class ImageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }
    }
}
