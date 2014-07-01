using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
	public interface IProduct
	{
		decimal Price { get; set; }
		double Weight { get; set; }
		int Stock { get; set; }
	}
}
