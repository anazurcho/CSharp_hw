using System;

namespace task_one
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
