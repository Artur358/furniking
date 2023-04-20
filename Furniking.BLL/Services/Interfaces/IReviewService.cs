using Furniking.BLL.DTOs.CategoryDTOs;
using Furniking.BLL.DTOs.ReviewDTOs;
using Furniking.DAL.Entities;

namespace Furniking.BLL.Services.Interfaces
{
	public interface IReviewService
	{
		Task<AddReviewDTO> AddReviewAsync(AddReviewDTO reviewDto);
		Task UpdateReviewAsync(Review review);
		Task<IEnumerable<GetAllReviewDTO>> GetPageReviewsAsync(int count, int page);
		Task<IEnumerable<GetAllReviewDTO>> GetAllReviewsAsync();
		Task<bool> DeleteReviewAsync(int reviewId);
		Task<bool> LikeAsync(int reviewId);
		Task<bool> DislikeAsync(int reviewId);
		Task<EditReviewDTO> EditAsync(EditReviewDTO editReview);
	}
}
