using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
	public class PublicMessage
	{
		private readonly IMessageCollector _messageCollector;
		private readonly ITextWriter _textWriter;

		public PublicMessage(IMessageCollector messageCollector, ITextWriter textWriter)
		{
			if (messageCollector == null) throw new ArgumentNullException("Message collector");
			if (textWriter == null) throw new ArgumentNullException("Text writer");
			_messageCollector = messageCollector;
			_textWriter = textWriter;
		}

		public void Shout()
		{
			string message = _messageCollector.CollectMessageFromUser();
			_textWriter.WriteText(message);
		}
	}
}
