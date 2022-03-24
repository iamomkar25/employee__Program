using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CheckEmployee
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (isPresent == empCheck)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Present");
                Console.ReadLine();
            }

        }


    }
}
