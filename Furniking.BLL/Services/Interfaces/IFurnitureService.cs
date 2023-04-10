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
        Task<bool> DeleteAsync(int id);
        Task<IList<FurnitureDTO>> GetAllAsync();
        Task<FurniturePageDTO> GetPageAsync(int page);
        Task<FurnitureDTO> GetAsync(int id);

    }
}
