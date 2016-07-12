using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            /// This is telling the terminal to print this out on the terminal
            Console.Write("> ");
            /// The word "String" here tells the program the type you are putting in"
            String user_name = Console.ReadLine();
        }
    }
}
