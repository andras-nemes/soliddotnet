using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class LogWriter : ITextWriter
	{
		private readonly ILogger _logger;
		private readonly ITextWriter _textWriter;

		public LogWriter(ILogger logger, ITextWriter textWriter)
		{
			if (logger == null) throw new ArgumentNullException("Logger");
			if (textWriter == null) throw new ArgumentNullException("TextWriter");
			_logger = logger;
			_textWriter = textWriter;
		}

		public void WriteText(string text)
		{
			_logger.Log();
			_textWriter.WriteText(text);
		}
	}
}
