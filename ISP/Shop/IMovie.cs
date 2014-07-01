using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
	public interface IMovie : IProduct
	{
		int RunningTime { get; set; }
	}
}
