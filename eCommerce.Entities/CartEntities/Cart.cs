﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities.CartEntities;

public class Cart
{
	public List<CartItem> CartItems { get; set; } = new List<CartItem>();
}
