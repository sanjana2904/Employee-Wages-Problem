using System;


namespace Employee_Wages_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());


        }
    }
}