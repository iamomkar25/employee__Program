﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UC3
{
    internal class EmpTime
    {
        
        public static void UC3()
        {
            Console.WriteLine("Welcome to UC3");
            Random random = new Random();
            int is_fulltime = 1;
            int is_parttime = 2;
            int totalWorkingHour = 8;
            int partTimeWorkingHour = 4;
            int wagePerHour = 20;
            int dailyWage = 0;
            int empCheck = random.Next(0, 3);

            if (empCheck == is_fulltime)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total wage of a day: " + dailyWage);
            }
            else if (empCheck == is_parttime)
            {
                Console.WriteLine("Employee is parttime worker");
                dailyWage = (partTimeWorkingHour * wagePerHour);
                Console.WriteLine("Total wage of halfday: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                dailyWage = totalWorkingHour * 0;
                Console.WriteLine("Total wage of a day: " + dailyWage);

            }
            Console.ReadLine();


        }

        static void Main(string[] args)
        {
          
            Program.UC3();
        }
    }
}
