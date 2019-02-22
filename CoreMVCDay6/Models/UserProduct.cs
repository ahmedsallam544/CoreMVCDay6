using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CoreMVCDay6.Models
{
    public class UserProduct
    {
       
        [ForeignKey("User")]
        public int UserID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
