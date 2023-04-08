namespace Furniking.BLL.DTOs.ReviewDTOs
{
	public class AddReviewDTO
	{
		public int Likes { get; set; }
		public int Dislikes { get; set; }
		public int Evaluation { get; set; }
		public string Comment { get; set; }
		public DateTime DateTime { get; set; }
		public int UserId { get; set; }
		public int FurnitureId { get; set; }
	}
}
