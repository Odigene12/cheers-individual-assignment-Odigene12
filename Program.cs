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
            // This will tell the terminal to print the content of the string in the terminal
            Console.WriteLine("What's your name?");
            // This is telling the terminal to print this out on the terminal
            Console.Write("> ");
            // The word "String" here tells the program the type you are putting in"
            String user_name = Console.ReadLine();
            // The "ToUpper()" method makes the string return all uppercase letters
            // user.name.ToUpper() is turning the user's name to uppercase.
            // ToUpper() is functionality specific to STRINGS
            // ToUpper() accepts no arguments
            
            Console.WriteLine(user_name.ToUpper() + " is..GRAND!");
        }
    }
}
