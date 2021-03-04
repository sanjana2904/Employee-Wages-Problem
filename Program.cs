﻿using System;

namespace Employee_Wages_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            // constants
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp wage:" + empWage);
            Console.ReadKey();

        }
    }
}
