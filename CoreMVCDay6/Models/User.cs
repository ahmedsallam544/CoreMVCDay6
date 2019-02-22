using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCDay6.Models
{
    public class User
    {
     
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual List<UserProduct> UserProducts { get; set; }


    }
}
