using System;

namespace task_one
{
	class User
	{

		public User( string firstName, string lastName, string address)
		{
			ID = User.generateId();
			FirstName = firstName;
			LastName = lastName;
			Address = address;
		}

		private string ID { get; set; }
		private string FirstName { get; set; }
		private string LastName { get; set; }
		private string Address { get; set; }

		public static string generateId()
		{
			return Guid.NewGuid().ToString();
		}
		public override string ToString()
		{
			return $"{ID} {FirstName} {LastName} from {Address}";
		}

		public void GetMessage(Message message)
		{
			Console.WriteLine($"{message}");
		}
	}
}
