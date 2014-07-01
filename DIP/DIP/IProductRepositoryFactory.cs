using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public interface IProductRepositoryFactory
	{
		IProductRepository Create(string repoDescription);
		IProductRepository CreateTestRepository();
		IProductRepository CreateSqlRepository();
		IProductRepository CreateMongoDbRepository();
	}
}
