﻿using System;


namespace Employee_Wages_Problem
{
	class Program
	{
		//static void Main(string[] args)
		//{
			const int IS_PART_TIME = 1;
			const int IS_FULL_TIME = 2;
			static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
			{
				//variables
				int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
				//computation

				while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
				{
					totalWorkingDays++;
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
					totalEmpHrs += empHrs;
					Console.WriteLine("day#:" + totalWorkingDays + " Emp Hrs :" + empHrs);
				}
				int totalEmpWage = totalEmpHrs * empRatePerHour;
				Console.WriteLine("total emp wage:" + company + " is: " + totalEmpWage);
				return totalEmpWage;
			}

			static void Main(string[] args)
			{
				computeEmpWage("DMART", 20, 2, 10);
				computeEmpWage("Reliance", 10, 4, 20);

			}
		}
	}
//}

	


