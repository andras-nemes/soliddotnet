using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class TestProductRepository : IProductRepository
	{
		public IEnumerable<Product> FindAll()
		{
			//contact some data store
			throw new NotImplementedException();
		}
	}
}
