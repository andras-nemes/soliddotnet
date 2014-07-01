using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DIP
{
	public abstract class TimeProviderContext
	{
		public static TimeProviderContext Current
		{
			get
			{
				TimeProviderContext timeProviderContext = Thread.GetData(Thread.GetNamedDataSlot("TimeProvider")) as TimeProviderContext;
				if (timeProviderContext == null)
				{
					timeProviderContext = TimeProviderContext.DefaultTimeProviderContext;
					Thread.SetData(Thread.GetNamedDataSlot("TimeProvider"), timeProviderContext);
				}
				return timeProviderContext;
			}
			set
			{
				Thread.SetData(Thread.GetNamedDataSlot("TimeProvider"), value);
			}
		}

		public static TimeProviderContext DefaultTimeProviderContext = new DotNetTimeProvider();

		public abstract DateTime GetTime { get; }
	}
}
