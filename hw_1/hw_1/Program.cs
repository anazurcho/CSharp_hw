using System;
using System.Collections.Generic;

namespace hw_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //ბევრი უკეთესი ვერსია არსებობს
            Dictionary<int, List<string>> users = new Dictionary<int, List<string>>()
            {
                {1, new List<String>(){"ana", "zurabashvili","Tbilisi"}},
                {2, new List<String>(){"Tornike", "Gomareli","Tbilisi"}},
                {3, new List<String>(){"username", "userlastname","Tbilisi"}},
            };
            //ვაპირებდი key ს დაგენერირებას და მერე იუზერის შექმნისას გადაცემას მაგრამ ასე დავტოვე 
            foreach (var item in users.Keys)
            {
                Console.WriteLine( $"{item} {string.Join(", ", users[item])}");
            }
            Console.WriteLine("Hello, I'm here to help u to send message to someone");
            Console.WriteLine("write Id ");
            int userInput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Now Message");
            Console.WriteLine("subject");
            string subject = Console.ReadLine();
            Console.WriteLine("message content");
            string content = Console.ReadLine();

            User to_whom = new User(users[userInput][0], users[userInput][1], users[userInput][2]);
            Message message = new Message(subject, content);

            Post post = new Post(to_whom, message);


        }
    }

}
