﻿using AutoMapper;
using Furniking.BLL.DTOs.ReviewDTOs;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Furniking.DAL.Repositories.Implementations;
using Furniking.DAL.Repositories.Interfaces;

namespace Furniking.BLL.Services.Implementations
{
	public class ReviewService : IReviewService
	{
		private readonly IReviewRepository _reviewRepository;
		private readonly IFurnitureRepository _furnitureRepository;
		private readonly IUserService _userService;
		private readonly IMapper _mapper;

		public ReviewService(IReviewRepository reviewRepository, IMapper mapper, IUserService userService, IFurnitureRepository furnitureRepository)
		{
			_userService = userService;
			_furnitureRepository = furnitureRepository;
			_reviewRepository = reviewRepository;
			_mapper = mapper;
		}
		public async Task<AddReviewDTO> AddReviewAsync(AddReviewDTO reviewDto)
		{
			var review = _mapper.Map<Review>(reviewDto);
			var addedReview = await _reviewRepository.AddAsync(review);
			if ((await _userService.GetByIdAsync(addedReview.UserId) == null))
			{
				throw new Exception("Invalid user Id");
			}
			if ((await _furnitureRepository.GetByIdAsync(addedReview.FurnitureId) == null))
			{
				throw new Exception("Invalid furniture Id");
			}
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

		public async Task<bool> DeleteReviewAsync(int reviewId)
		{
			return await _reviewRepository.DeleteByIdAsync(reviewId);
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
