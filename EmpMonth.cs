using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UC5
{
    internal class EmpMonth
    {
        public static void UC5()
        {
            Console.WriteLine("Welcome to UC4");

            int is_fulltime = 1;
            int is_parttime = 2;
            int totalWorkingHour = 0, wagePerHour = 20, dailyWage = 0;
            int totalWorkingDay = 1, workinghour;

            while (totalWorkingDay < 20)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        workinghour = 8;
                        Console.WriteLine("Employee is Present");
                        break;
                    case 2:
                        workinghour = 4;
                        Console.WriteLine("Employee is Parttime Worker");
                        break;
                    default:
                        workinghour = 0;
                        Console.WriteLine("Employee is Absent");
                        break;


                }
                totalWorkingDay++;
                totalWorkingHour = totalWorkingHour + workinghour;

            }
            dailyWage = wagePerHour * totalWorkingHour;

            //Console.WriteLine("Total wage is : " + dailyWage);
            Console.WriteLine("Total wage is : " + dailyWage);
            Console.ReadLine();
        }



        static void Main(string[] args)
        {
         
            Program.UC5();
        }
    }
}
