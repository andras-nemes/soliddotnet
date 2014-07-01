using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
	public class BluRay : IMovie
	{
		public decimal Price { get; set; }
		public double Weight { get; set; }
		public int Stock { get; set; }
		public int RunningTime { get; set; }
	}
}
