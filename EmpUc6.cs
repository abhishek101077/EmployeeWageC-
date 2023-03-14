using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograme
{
    internal class EmpUc6
    {
    
        public static void solution()
        { }
        
        
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static void solution(string[] arg)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation Program");
            int empHrs;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "  " + "Working Hours : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine($"totalEmpHrs : {totalEmpHrs}  *  EMP_RATE_PER_HOUR : {EMP_RATE_PER_HOUR} = totalEmpWage : {totalEmpWage}");
            Console.ReadLine();
        }
        


        }
    }

