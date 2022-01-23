// See https://aka.ms/new-console-template for more information
using Employee_Wage;
Console.WriteLine("Employee Wage");

//EmpWage.PresentOrNOt();
//EmpWage.EmployeFullTime();
//EmpWage.FulltimeOrPartime();

// calculating Wage for multiple companies


CalculateWage company = new CalculateWage();
company.AddCompany("apple", 30, 120, 25);
company.AddCompany("tata", 25, 125, 200);
company.AddCompany("Tesla", 40, 110, 300);
company.GetWage();
Console.WriteLine("Total Wage for Company is: " + company.GetTotalWage("Tesla"));
Console.WriteLine("Total Wage for Company is: " + company.GetTotalWage("apple"));
Console.WriteLine("Total Wage for Company is: " + company.GetTotalWage("tata"));
Console.ReadLine();