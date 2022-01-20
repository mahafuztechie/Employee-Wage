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
        //method to check employee employee present fulltime 
        public static void EmployeFullTime()
        {
            const int FullTime = 1;
            int empWagePerHr = 20;
            int empHr = 0;
            int totalWage = 0;
            Random random = new Random();
            int RandomNumber = random.Next(0, 2);
       

            if (RandomNumber == FullTime)
            {
                Console.WriteLine("Emplyee worked for full time");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Emplyee is absent");
            }

            totalWage = empWagePerHr * empHr;
            Console.WriteLine("Total wage of employee for full time is" + totalWage);

        }

    }
    }

