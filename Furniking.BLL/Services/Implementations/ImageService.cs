using AutoMapper;
using Furniking.BLL.DTOs.ImageDTOs;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.Services.Implementations
{
    public class ImageService : IImageService
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ImageService(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<ImageDTO> Get(int id)
        {
            var image = await dataContext.Images.FindAsync(id);
            if (image == null)
                throw new Exception("Image not found");

            return _mapper.Map<ImageDTO>(image);
        }

        public int Upload(ImageDTO image)
        {
            if (image == null)
                throw new Exception("ImageDTO is null");
            if (image.Data.Length < 0)
                throw new Exception("Image data is null");

            var imageId = dataContext.Images.Add(_mapper.Map<Image>(image)).Entity.Id;
            dataContext.SaveChanges();

            return imageId;
        }

        public IEnumerable<int> Upload(ICollection<ImageDTO> images)
        {
            var ids = new List<int>(images.Count);

            foreach (var image in images)
            {
                ids.Add( Upload(image));
            }
            return ids;
        }
    }
}
