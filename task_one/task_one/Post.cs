using System;

namespace task_one
{
	class Post
	{
		internal Post(User user, Message message)
		{
			Console.WriteLine($"\n {message}  \n to {user}!");
		}
	}
}
