using Furniking.DAL.Data;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Furniking.DAL.Repositories.Implementations
{
	public class ReviewRepository : Repository<Review>, IReviewRepository
	{
		private readonly IRepository<Review> _reviewRepository;

		public ReviewRepository(DataContext dbContext, IRepository<Review> reviewRepository) : base(dbContext)
		{
			_reviewRepository = reviewRepository;
		}			
		public async Task<IEnumerable<Review>> GetPageReviewsAsync(int count, int page)
		{
			return await _dbContext.Reviews.Skip(count * (page-1)).Take(count).ToListAsync();
		}
		public async Task<bool> LikeAsync(int reviewId)
		{
			var review = await _reviewRepository.GetByIdAsync(reviewId);
			if (review == null)
			{
				return false;
			}

			review.Likes++;
			await _reviewRepository.UpdateAsync(review);
			return true;
		}

		public async Task<bool> DislikeAsync(int reviewId)
		{
			var review = await _reviewRepository.GetByIdAsync(reviewId);
			if (review == null)
			{
				return false;
			}

			review.Dislikes++;
			await _reviewRepository.UpdateAsync(review);
			return true;
		}

	}
}
