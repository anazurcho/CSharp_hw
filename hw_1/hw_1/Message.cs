using System;
using System.Collections.Generic;
using System.Text;

namespace hw_1
{
	internal class Message
	{
		public Message(string subject, string content)
		{
			Subject = subject;
			Content = content;
		}

		private string Subject { get; set; }
		private string Content { get; set; }
		public override string ToString()
		{
			return $"{Subject} \n{Content}";
		}
	}
}
