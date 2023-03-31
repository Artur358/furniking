﻿namespace Furniking.DAL.Entities
{
    public class Furniture : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Image> Images { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        // ... 

    }
}