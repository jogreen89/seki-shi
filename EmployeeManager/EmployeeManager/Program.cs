using System;

namespace EmployeeManager
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: EmployeeManager [OPTION]... DATA [ACTION]...");
                Console.WriteLine("Try 'grep --help' for more information.");
                return 1;
            }
            // 
            Console.WriteLine("Welcome to Employee Manager.");

            return 0;
        }
    }
    class Employee
    {

    }
}