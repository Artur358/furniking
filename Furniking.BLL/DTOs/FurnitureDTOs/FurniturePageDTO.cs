namespace Furniking.BLL.DTOs.FurnitureDTOs
{
    public class FurniturePageDTO
    {
        public int Page { get; set; }
        public int TotalCount { get; set; }
        public int PageCount { get; set; }
        public ICollection<FurnitureDTO> Furnitures { get; set; }
    }
}
