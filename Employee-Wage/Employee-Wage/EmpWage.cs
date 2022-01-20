using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class EmpWage
    {

        //method to calculate wage using Whileloop usecase
        public static void CalculateWage()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int totalWage = 0;
            int empHrs = 0;
            int empWage;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int days = 1;
            int empWorkingHrs = 0;


            
            Random random = new Random();
            //whileloop to iterate days out of max working days & employee working hrs out of max working hrs
            while (days <= MAX_WORKING_DAYS && empWorkingHrs <= MAX_WORKING_HRS)
            {


                int randomInput = random.Next(0, 3);
                // switch Case to check if employee is present fulltime partime or absent
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
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("employee wage for Day {0} is {1}", days, empWage);
                totalWage += empWage;
                empWorkingHrs += empHrs;
                days++;

            }
            Console.WriteLine("total wage for {0}Days and hrs:{1} is:{2} ", MAX_WORKING_DAYS, empWorkingHrs, totalWage);
        }

    }
    }

