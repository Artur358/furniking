using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Entities
{
    public class User : IdentityUser
    {


        public virtual IList<Order> Orders { get; set; }
        public virtual IList<Review> Reviews { get; set; }
        
        
    }
}
