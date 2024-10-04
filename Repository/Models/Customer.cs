﻿using System;
using System.Collections.Generic;

namespace RolexApplication_DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int CustomerId { get; set; }
        public string Email { get; set; } = null!;
        public string HashedPassword { get; set; } = null!;
        public int Status { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime? DoB { get; set; }
        public string? Avatar { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
