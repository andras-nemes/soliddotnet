﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public interface IProductRepository
	{
		IEnumerable<Product> FindAll();
	}
}
