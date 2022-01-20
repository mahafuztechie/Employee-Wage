using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class EmpWage
    {
            public const int FULL_TIME = 1;
            public const int PART_TIME = 2;
            public static int empHrs = 0;
            public static void CalculateWage()
            {

                int totalWage = 0;
                int empWage;
                const int EMP_RATE_PER_HR = 20;
                const int MAX_WORKING_DAYS = 20;
                const int MAX_WORKING_HRS = 100;
                int days = 1;
                int empWorkingHrs = 0;


            // while loop to check if days out of max working days &  working hours out of max working hours
                Random random = new Random();
                while (days <= MAX_WORKING_DAYS && empWorkingHrs <= MAX_WORKING_HRS)
                {
                    int randomInput = random.Next(0, 3);
                //calling method to fetch working hours
                    GetWorkingHrs(randomInput);
                    empWage = EMP_RATE_PER_HR * empHrs;
                    Console.WriteLine("EMployee wage for Day {0} is {1}", days, empWage);
                    totalWage += empWage;
                    empWorkingHrs += empHrs;
                    days++;

                }
                Console.WriteLine("total wage for {0}Days and hrs:{1} is:{2} ", MAX_WORKING_DAYS, empWorkingHrs, totalWage);
            }

        // functional programming to refactor code
        // this method prints if emplyee is present full time or partime or absent 
            public static void GetWorkingHrs(int randomInput)
            {

                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("Employee is present fulltime");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("Employee is present parttime");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                }
            }

        }
}

