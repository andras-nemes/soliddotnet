using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class CachedProductService : IProductService
	{
		private readonly IProductService _innerProductService;
		private readonly ICacheStorage _cacheStorage;

		public CachedProductService(IProductService innerProductService
			, ICacheStorage cacheStorage)
		{
			if (innerProductService == null) throw new ArgumentNullException("ProductService");
			if (cacheStorage == null) throw new ArgumentNullException("CacheStorage");
			_cacheStorage = cacheStorage;
			_innerProductService = innerProductService;
		}

		public Product GetProduct(int productId)
		{
			string key = "Product|" + productId;
			Product p = _cacheStorage.Retrieve<Product>(key);
			if (p == null)
			{
				p = _innerProductService.GetProduct(productId);
				_cacheStorage.Store(key, p);
			}

			return p;
		}
	}
}
