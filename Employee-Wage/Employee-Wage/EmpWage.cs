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
            const int PART_TIME = 0;
            int empWagePerHr = 20;
            int empHr = 0;
            int totalWage = 0;
            Random random = new Random();
            int RandomNumber = random.Next(0, 3);
       

            if (RandomNumber == FULL_TIME)
            {
                Console.WriteLine("Employee worked for full time");
                empHr = 8;
            }
            // checking if employee is present part-time
            else if (RandomNumber == PART_TIME)
            {
                Console.WriteLine("Employee worked for part time");
                empHr = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHr = 0;
            }

            totalWage = empWagePerHr * empHr;
            Console.WriteLine("Total wage of employee for is" + totalWage);

        }

    }
    }

