using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;

namespace DIP
{
	public class DefaultProductService : IProductService
	{		
		public Product GetProduct(int productId)
		{
			return new Product();
		}
	}
}
