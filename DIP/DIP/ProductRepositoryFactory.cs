using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class ProductRepositoryFactory : IProductRepositoryFactory
	{
		public IProductRepository Create(string repositoryTypeDescription)
		{
			switch (repositoryTypeDescription)
			{
				case "default":
					return new ProductRepository();
				case "test":
					return new TestProductRepository();
				default:
					throw new NotImplementedException();
			}
		}


		public IProductRepository CreateTestRepository()
		{
			throw new NotImplementedException();
		}

		public IProductRepository CreateSqlRepository()
		{
			throw new NotImplementedException();
		}

		public IProductRepository CreateMongoDbRepository()
		{
			throw new NotImplementedException();
		}
	}
}
