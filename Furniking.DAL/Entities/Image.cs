using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniking.DAL.Entities
{
    public class Image
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }

        public virtual Furniture Furniture { get; set; }
    }
}
