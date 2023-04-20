using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.BLL.DTOs.ReviewDTOs
{
	public class EditReviewDTO
	{
		public int Id { get; set; }
		public string Comment { get; set; }
		public int Evalution { get; set; }
	}
}
