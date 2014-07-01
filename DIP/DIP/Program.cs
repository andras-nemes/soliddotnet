using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	class Program
	{
		static void Main(string[] args)
		{
			IMessageCollector messageCollector = new ConsoleMessageCollector();
			ITextWriter textWriter = new LogWriter(new DefaultLogger(), new ConsoleTextWriter());
			PublicMessage publicMessage = new PublicMessage(messageCollector, textWriter);
			publicMessage.Shout();

			Console.ReadKey();
		}
	}
}
