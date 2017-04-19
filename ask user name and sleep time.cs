using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();
            Console.WriteLine("how many hours of sleep did you get last night?");
            int hoursOfSleep =int.Parse(Console.ReadLine());
            
            Console.WriteLine("hello " + name);
            if (hoursOfSleep > 8)
            { 
            Console.WriteLine("you are well rested");
            }
            else
            {
                Console.WriteLine("you need more sleep");
            }
            Console.ReadLine();
        }
    }
}
