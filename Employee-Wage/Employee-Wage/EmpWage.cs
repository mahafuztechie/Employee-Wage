using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class EmpWage
    {
      
        //method to check if employee present or not
        public static void PresentOrNOt()
            {
                Random random = new Random();

                int RandomNumber = random.Next(0, 2);


                if (RandomNumber == 0)
                {
                    Console.WriteLine("Emplyee is Present");
                }
                else
                {
                    Console.WriteLine("Emplyee is absent");
                }

            }
        //method to check employee employee present fulltime or partime or absent
        public static void FulltimeOrPartime()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int totalWage = 0;
            int empHrs = 0;
            int empWage = 0;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            int day = 1;
            Random random = new Random();

            // using for loop to check employee working days with total Wage
            for (day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int randomInput = random.Next(0, 3);

               // with iflse
                //if (RandomNumber == FULL_TIME)
                //{
                //    Console.WriteLine("Employee worked for full time");
                //    empHr = 8;
                //}
                //// checking if employee is present part-time
                //else if (RandomNumber == PART_TIME)
                //{
                //    Console.WriteLine("Employee worked for part time");
                //    empHr = 4;
                //}
                //else
                //{
                //    Console.WriteLine("Employee is absent");
                //    empHr = 0;
                //}

                // switch case
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
                totalWage += empWage;
                Console.WriteLine("Employee wage for Day {0} is {1}", day, empWage);
            }
            Console.WriteLine("total wage is " + totalWage);
        }

    }
    }

