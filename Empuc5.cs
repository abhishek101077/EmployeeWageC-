using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograme
{
    public class Empuc5
    {
        public static void solution()
        { }
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;



        public static void solution(string[] arg)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");
            int empHrs = 0;
            int empWage = 0;
            int TotalEmpWage = 0;
            for (int days = 1; days <= NUM_OF_WORKING_DAYS; days++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        // Console.WriteLine("Full Time Employee is Present");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        //  Console.WriteLine("Part Time Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        //   Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HOUR * empHrs;
                TotalEmpWage += empWage;
            }
            Console.WriteLine("Assumed 20 Working Day in a Month the Employee Wage is : " + TotalEmpWage);

            Console.ReadLine();

        }
        }
}
