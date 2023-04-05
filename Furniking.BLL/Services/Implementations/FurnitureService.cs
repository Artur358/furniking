using AutoMapper;
using Furniking.BLL.DTOs.FurnitureDTOs;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.Services.Implementations
{
    public class FurnitureService : IFurnitureService
    {
        private readonly IFurnitureRepository _furnitureRepository;
        private readonly IMapper _mapper;

        public FurnitureService(IFurnitureRepository furnitureRepository, IMapper mapper)
        {
            _furnitureRepository = furnitureRepository;
            _mapper = mapper;
        }


        public async Task<FurnitureDTO> CreateAsync(CreateFurnitureDTO furniture)
        {
            var m = _mapper.Map<Furniture>(furniture);
            _ = m;

            var createdFurniture = await _furnitureRepository.AddAsync(m);
            _ = createdFurniture;
            var cat = createdFurniture.Category;
            _ = cat;
            return _mapper.Map<FurnitureDTO>(createdFurniture);
        }

        public Task<FurnitureDTO> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FurnitureDTO> EditAsync(FurnitureDTO furniture)
        {
            throw new NotImplementedException();
        }

        public Task<IList<FurnitureDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FurnitureDTO> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FurniturePageDTO> GetPageAsync(int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
