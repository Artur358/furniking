using Furniking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Repositories.Interfaces
{
	public interface IReviewRepository : IRepository<Review>
	{
		Task<IEnumerable<Review>> GetPageReviewsAsync(int page, int pageSize);
		Task<bool> LikeAsync(int reviewId);
		Task<bool> DislikeAsync(int reviewId);
	}
}
