﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class Category: BaseEntity
    {
        public ICollection<Product> Products { get; set; }
    }
}
