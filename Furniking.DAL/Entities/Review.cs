using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Entities
{
    public class Review
    {
        public int Id { get; set; }
        // 1-5
        public int Evaluation { get; set; }
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }



        public int FurnitureId { get; set; }
        public Furniture Furniture { get; set; }

        


    }
}
