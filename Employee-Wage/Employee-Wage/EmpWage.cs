using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal interface IComputeEnpWage
    {
        public void AddCompany(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs);
        public void GetWage();
        public int CalWage(EmpWage emp);
           
    }
    class EmpWage
    {
        public string company;
        public int empRatePerHr, maxWorkingDays, maxWorkingHrs, totalWage;
       // constructor to initialize variable
        public EmpWage(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
     
    }
}

