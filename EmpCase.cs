using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UC4
{
    internal class EmpCase
    {

        public static void UC4()
        {
            int is_fulltime = 1;
            int is_parttime = 2;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            

            int totalWorkingHour, wagePerHour = 20, dailyWage = 0;
            switch (empCheck)
            {
                case 1:
                    totalWorkingHour = 8;
                    Console.WriteLine("Employee is Present");
                    break;
                case 2:
                    totalWorkingHour = 4;
                    Console.WriteLine("Employee is Parttime Worker");
                    break;
                default:
                    totalWorkingHour = 0;
                    Console.WriteLine("Employee is Absent");
                    break;


            }
            dailyWage = wagePerHour * totalWorkingHour;
            Console.WriteLine("Total wage is : " + dailyWage);
            Console.ReadLine();
        }



        static void Main(string[] args)
        {
            
            Program.UC4();
        }

    }
}
