using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
	public class DVD : IMovie
	{
		public double Weight { get; set; }
		public int Stock { get; set; }
		public int RunningTime { get; set; }
		public decimal Price { get; set; }

		public void DoSomething(IMovie movie)
		{

		}

		public void DoSomethingElse(IProduct product)
		{

		}
	}
}
