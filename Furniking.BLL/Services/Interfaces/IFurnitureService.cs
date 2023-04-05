using Furniking.BLL.DTOs.FurnitureDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.Services.Interfaces
{
    public interface IFurnitureService
    {
        Task<FurnitureDTO> CreateAsync(CreateFurnitureDTO furniture);
        Task<FurnitureDTO> EditAsync(FurnitureDTO furniture);
        Task<FurnitureDTO> DeleteAsync(int id);
        Task<IList<FurnitureDTO>> GetAllAsync();
        Task<FurniturePageDTO> GetPageAsync(int page, int pageSize);
        Task<FurnitureDTO> GetAsync(int id);

    }
}
