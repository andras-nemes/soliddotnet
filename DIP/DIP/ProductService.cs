using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class ProductService
	{
		private IProductRepository _productRepository;

		public ProductService() : this(new ProductRepositoryFactory().Create("sql"))
		{}

		public ProductService(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public IProductRepository ProductRepository 
		{
			get
			{
				if (_productRepository == null)
				{
					_productRepository = new ProductRepository();
				}
				return _productRepository;
			}
			set
			{
				if (value == null) throw new ArgumentNullException("ProductRepo");
				if (_productRepository != null) throw new InvalidOperationException("You are not allowed to set this dependency more than once.");
				_productRepository = value;
			}
		}

		public IEnumerable<Product> GetProducts(IProductDiscountStrategy productDiscount)
		{
			if (productDiscount == null) throw new ArgumentNullException("Discount strategy");
			IEnumerable<Product> productsFromDataStore = _productRepository.FindAll();
			foreach (Product p in productsFromDataStore)
			{
				p.AdjustPrice(productDiscount);
			}
			return productsFromDataStore;
		}

		public DateTime TestTime()
		{
			return TimeProviderContext.Current.GetTime;
		}
	}
}
