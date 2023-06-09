﻿
using System.ComponentModel.DataAnnotations;

namespace Furniking.DAL.Entities
{
    public class Furniture : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        public virtual Image MainImage { get; set; }
        public virtual ICollection<FurnitureGalery> Galery { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        // ... 

    }
}
