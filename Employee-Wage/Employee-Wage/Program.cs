// See https://aka.ms/new-console-template for more information
using Employee_Wage;
Console.WriteLine("Employee Wage");

//EmpWage.PresentOrNOt();
//EmpWage.EmployeFullTime();
//EmpWage.FulltimeOrPartime();

// calculating Wage for multiple companies


CalculateWage company = new CalculateWage();
company.AddCompany("Dmart", 30, 120, 25);
company.AddCompany("Reliance", 25, 125, 200);
company.AddCompany("Amazon", 40, 110, 300);
company.GetWage();
Console.ReadLine();