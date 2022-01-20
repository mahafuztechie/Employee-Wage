// See https://aka.ms/new-console-template for more information
using Employee_Wage;
Console.WriteLine("Employee Wage");

//EmpWage.PresentOrNOt();
//EmpWage.EmployeFullTime();
//EmpWage.FulltimeOrPartime();

// calculating Wage for multiple companies
EmpWage emp1 = new EmpWage();
emp1.CalculateWage("jio", 20, 30, 200);
emp1.CalculateWage("airtel", 30, 50, 200);

