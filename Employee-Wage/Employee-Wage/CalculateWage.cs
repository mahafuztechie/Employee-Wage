﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class CalculateWage : IComputeEnpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public static int empHrs = 0;
        int empWage;
        int days = 1;
        int empWorkingHrs = 0;

        //declaring list And dictionary
        public IList<EmpWage> CompanyEmpWge;
        public IDictionary<string, EmpWage> employees;
        
        //constructor to initialize list & dictionary
        public CalculateWage()
        {
            this.CompanyEmpWge = new List<EmpWage>();
            this.employees = new Dictionary<string, EmpWage>();
        }
        public void AddCompany(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            EmpWage emp = new EmpWage(company, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            CompanyEmpWge.Add(emp);       //storing details in list
            employees.Add(company, emp);
        }
        
        public void GetWage()
        {
            //iterating to get and set total wage 
          foreach(EmpWage empWage in this.CompanyEmpWge)
            {
                empWage.SetTotalWage(CalWage(empWage));
            }
        }



        public int CalWage(EmpWage emp)
        {
            int totalWage = 0;
         
            Random random = new Random();
            while (empWorkingHrs <= emp.maxWorkingHrs && days <= emp.maxWorkingDays)
            {

                int randomInput = random.Next(0, 3);
                // calling method to fetch working hours
                GetWorkingHrs(randomInput);
                empWage = emp.empRatePerHr * empHrs;
                //Console.WriteLine("Employee wage for DAy {0} is {1}", days, empWage);
                totalWage += empWage;
                empWorkingHrs += empHrs;

                if (empWorkingHrs > emp.maxWorkingHrs)
                {
                    empWorkingHrs = emp.maxWorkingHrs;
                    break;
                }
                days++;

            }
            Console.WriteLine("\n company : {0} , Total wage is : {1} ", emp.company, totalWage);
            return totalWage;
        }

        //method to get total company wage
        public int GetTotalWage(string company)
        {
            return this.employees[company].totalWage;
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
