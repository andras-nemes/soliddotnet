using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class ConsoleTextWriter : ITextWriter
	{
		public void WriteText(string text)
		{
			Console.WriteLine(text);
		}
	}
}
