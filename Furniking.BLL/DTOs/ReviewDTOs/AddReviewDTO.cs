namespace Furniking.BLL.DTOs.ReviewDTOs
{
	public class AddReviewDTO
	{
		public string Comment { get; set; }
		public int UserId { get; set; }
		public int FurnitureId { get; set; }
	}
}
