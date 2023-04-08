using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Entities
{
    public class Review : BaseEntity
    {
        
        // 1-5
        public byte Evaluation { get; set; } 
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }
		public int Likes { get; set; } 
        public int Dislikes { get; set; } 

		public int UserId { get; set; }
        public virtual User User { get; set; }


        public int FurnitureId { get; set; }
        public virtual Furniture Furniture { get; set; }

    }
}
