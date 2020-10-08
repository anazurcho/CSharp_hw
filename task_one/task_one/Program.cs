using System;

namespace task_one
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-----------------------------");

			Console.WriteLine("Hello, I'm here to help u to send message to someone");
			Console.WriteLine("firstname lastname address");
			string[] userInputs = Console.ReadLine().Split();


			Console.WriteLine("Now Message");
			Console.WriteLine("subject");
			string subject = Console.ReadLine();
			Console.WriteLine("message content");
			string content = Console.ReadLine();

			User to_whom = new User(userInputs[0], userInputs[1], userInputs[2]);
			Message message = new Message(subject, content);

			Post post = new Post(to_whom, message);



		}
	}
}
