using Furniking.BLL.DTOs.ImageDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.Services.Interfaces
{
    public interface IImageService
    {
        Task<ImageDTO> Get(int id);
        int Upload(ImageDTO image);
        IEnumerable<int> Upload(ICollection<ImageDTO> images);

    }
}
