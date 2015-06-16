using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type of something:");
            string userValue;
            userValue = Console.ReadLine();
            Console.WriteLine("You typed: " + userValue);

            string message = (userValue == "Crap") ? "Not Nice!" : "Thanks!";
            Console.WriteLine("All I can say is  {0} {1}", userValue, message);
  
            Console.ReadLine();
        }
    }
}
