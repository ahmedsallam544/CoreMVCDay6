﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCDay6.Models
{
    public class Product
    {
        //jhbgjdbkjcbaskcjjb
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public virtual List<UserProduct> UserProducts { get; set; }


    }
}
