﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionApi.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string imageUrl { get; set; }
    }
}
