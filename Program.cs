using System;

namespace Employee_Wages_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
			const int IS_PART_TIME = 1;
			const int IS_FULL_TIME = 2;
			const int EMP_RATE_PER_HOUR = 20;
			const int NUM_OF_WORKING_DAYS = 2;
			const int MAX_HRS_IN_MONTH = 10;

			// constants
			//variables
			int empHrs = 0;
			int totalEmpHrs = 0;
			int totalWorkingDays = 0;
			// computation
			while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
			int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
			Console.WriteLine("total emp wage:" + totalEmpWage);
		}

	}
}
