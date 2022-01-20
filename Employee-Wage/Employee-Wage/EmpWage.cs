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

        // creating a reusable method to calculate wage for multiple companies 
        public void CalculateWage(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            int totalWage = 0;
            int empWage;
            int days = 1;
            int empWorkingHrs = 0;

            Random random = new Random();
            while (empWorkingHrs <= maxWorkingHrs && days <= maxWorkingDays)
            {


                int randomInput = random.Next(0, 3);
                // calling method to fetch working hours
                GetWorkingHrs(randomInput);
                empWage = empRatePerHr * empHrs;
                //Console.WriteLine("Employee wage for DAy {0} is {1}", days, empWage);
                totalWage += empWage;
                empWorkingHrs += empHrs;

                if (empWorkingHrs > maxWorkingHrs)
                {

                    empWorkingHrs = maxWorkingHrs;
                    break;
                }
                days++;

            }
            Console.WriteLine(" In {0} company Employee worked for {1}days out of {2}days and {3}hours out of {4}hours so Employee wage is:{5} ", company, days - 1, maxWorkingDays, empWorkingHrs, maxWorkingHrs, totalWage);
        }

        //method to calculate  calculate working hours
        public static void GetWorkingHrs(int randomInput)
        {

            switch (randomInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    //Console.WriteLine("Employee is present fulltime "+empHrs);
                    break;
                case PART_TIME:
                    empHrs = 4;
                    //Console.WriteLine("Employee is present parttime " +empHrs);
                    break;
                default:
                    empHrs = 0;
                    //Console.WriteLine("Employee is absent " +empHrs);
                    break;
            }
        }
    }
}

