﻿using System;
using System.Collections.Generic;

namespace RolexApplication_DAL.Models
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
