using Furniking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Data.Helpers
{
	public static class LoadFakeDataHelper
	{
		public static void LoadFakeData(this DataContext db)
		{

			if (!db.Categories.Any())
			{
				for (int i = 0; i < 5; i++)
				{
					db.Categories.Add(new Category()
					{
						Name = $"Name-${i}"
					});
				}
			}
			if (!db.Reviews.Any())
			{
				foreach (var u in db.Users)
				{
					for (int i = 1; i <= 5; i++)
					{
						db.Reviews.Add(new Review()
						{
							Comment = $"Descriprion-${i}",
							Evaluation = (byte)i,
							Likes = (byte)i,
							Dislikes = (byte)i * 3,
							UserId = u.Id,
							FurnitureId = 2
						});
					}
				}
			}

			if (!db.Furnitures.Any())
			{
				foreach (var c in db.Categories)
				{
					for (int i = 0; i < 5; i++)
					{
						db.Furnitures.Add(new Furniture()
						{
							CategoryId = c.Id,
							Name = $"Furniture-{i}",
							Description = $"Description-{i}",
							Price = i * 100

						});
					}
				}
			}

			if (!db.Users.Any())
			{
				for (int i = 0; i < 5; i++)
				{
					db.Users.Add(new User()
					{
						Email = $"Email-{i}",
						UserName = $"Username-{i}",
						PasswordHash = $"Password-{i}",
					});
				}
			}



			db.SaveChanges();
		}
	}

}
