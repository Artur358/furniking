using System.ComponentModel.DataAnnotations;

namespace Furniking.Models
{
    public class FurnitureViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }


        [DataType(dataType: DataType.Upload)]
        public IFormFile MainImage { get; set; }

        [DataType(dataType: DataType.Upload)]
        //public ICollection<IFormFile> Images { get; set; }
        public IFormFileCollection formFiles { get; set; }

        //[DataType(dataType: DataType.Upload)]
        //public byte[] Data { get; set; }

    }
}
