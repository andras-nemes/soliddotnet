using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class ConsoleMessageCollector : IMessageCollector
	{
		public string CollectMessageFromUser()
		{
			Console.Write("Type your message to the world: ");
			return Console.ReadLine();
		}
	}
}
