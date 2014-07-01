using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			DVD dvd = new DVD();
			dvd.DoSomething(new DVD());
			dvd.DoSomethingElse(new DVD());
		}


	}
}
