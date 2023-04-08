using Furniking.BLL.DTOs.ReviewDTOs;
using Furniking.BLL.Services.Implementations;
using Furniking.BLL.Services.Interfaces;
using Furniking.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Furniking.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class ReviewController: ControllerBase
	{
		private readonly IReviewService _reviewService;

		public ReviewController(IReviewService review)
		{
			_reviewService = review;
		}
		[HttpGet()]
		public async Task<IActionResult> GetAllReviews()
		{
			return Ok(await _reviewService.GetAllReviewsAsync());
		}
		[HttpGet("next-page")]
		public async Task<IActionResult> GetNextPageReviews(int count, int currentPage)
		{
			var nextPage = currentPage + 1;
			return Ok(await _reviewService.GetPageReviewsAsync(count, nextPage));
		}

		[HttpPost("/review/add")]
		public async Task<IActionResult> CreateReview([FromBody] AddReviewDTO reviewDTO)
		{
			if (int.TryParse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out int userId))
			{
				reviewDTO.UserId = userId;
				var createdReview = await _reviewService.AddReviewAsync(reviewDTO);
				if (createdReview == null)
				{
					return BadRequest();
				}

				return Ok(createdReview);
			}
			else
			{
				return BadRequest("User ID is not valid.");
			}
		}
		[HttpPost("{reviewId}/likes")]
		public async Task<IActionResult> AddLikeAsync(int reviewId)
		{
			if (await _reviewService.LikeAsync(reviewId))
				return Ok();

			return NotFound();
		}

		[HttpPost("{reviewId}/dislikes")]
		public async Task<IActionResult> AddDislikeAsync(int reviewId)
		{
			if (await _reviewService.DislikeAsync(reviewId))
				return Ok();

			return NotFound();
		}

	}
}
