using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class DotNetTimeProvider : TimeProviderContext
	{
		public override DateTime GetTime
		{
			get { return DateTime.Now; }
		}
	}
}
