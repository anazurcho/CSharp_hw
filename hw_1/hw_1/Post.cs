using System;
using System.Collections.Generic;
using System.Text;

namespace hw_1
{
    class Post
    {
        internal Post(User user, Message message)
        {
            Console.WriteLine($"\n {message}  \n to {user}!");
        }
    }
}
