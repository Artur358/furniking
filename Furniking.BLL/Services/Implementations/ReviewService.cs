using AutoMapper;
using Furniking.BLL.DTOs.ReviewDTOs;
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
	public class ReviewService : IReviewService
	{
		private readonly IReviewRepository _reviewRepository;
		private readonly IMapper _mapper;

		public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
		{
			_reviewRepository = reviewRepository;
			_mapper = mapper;
		}
		public async Task<AddReviewDTO> AddReviewAsync(AddReviewDTO reviewDto)
		{
			var review = _mapper.Map<Review>(reviewDto);
			var addedReview = await _reviewRepository.AddAsync(review);
			return _mapper.Map<AddReviewDTO>(addedReview);
		}

		public async Task<IEnumerable<Review>> GetPageReviewsAsync(int count, int page)
		{
			return await _reviewRepository.GetPageReviewsAsync(count, page);
		}
		public async Task<IEnumerable<Review>> GetAllReviewsAsync()
		{
			return await _reviewRepository.GetAllAsync();
		}

		public async Task UpdateReviewAsync(Review review)
		{
			await _reviewRepository.UpdateAsync(review);
		}

		public async Task DeleteReviewAsync(int reviewId)
		{
			await _reviewRepository.DeleteByIdAsync(reviewId);
		}
		public async Task<bool> LikeAsync(int reviewId)
		{
			var review = await _reviewRepository.GetByIdAsync(reviewId);
			if (review == null)
				return false;

			review.Likes++;
			await _reviewRepository.UpdateAsync(review);
			return true;
		}

		public async Task<bool> DislikeAsync(int reviewId)
		{
			var review = await _reviewRepository.GetByIdAsync(reviewId);
			if (review == null)
				return false;

			review.Dislikes++;
			await _reviewRepository.UpdateAsync(review);
			return true;
		}
	}
}
