﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse_MySQL.Models.ViewModel
{
    public class ShoppingCartViewModel
    {
        public List<Product> Products { get; set; }
        public Appointments Appointments { get; set; }
    }
}
