
using Basic_Program;
/*StudentMarks studentMarks = new StudentMarks();*/
StudentGrade studentGrade = new StudentGrade();
Console.WriteLine("Enter The student Id");
studentGrade.StudentId =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The student Name");

studentGrade.StudentName = Console.ReadLine();
Console.WriteLine("Enter the Student City");
studentGrade.StudentCity = Console.ReadLine();
Console.WriteLine("Enter the Three subject Marks");
studentGrade.MarkOne = Convert.ToInt32(Console.ReadLine());
studentGrade.MarkTwo = Convert.ToInt32(Console.ReadLine());
studentGrade.MarkThree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Student details");
studentGrade.DisplayStudentDetails();
Console.WriteLine($"Marks of Three Subject:\n {studentGrade.MarkOne}\n{studentGrade.MarkTwo}\n{studentGrade.MarkThree}\n");
Console.Write($"Total Mark of student:{studentGrade.CalculateTotal()}\n");
Console.WriteLine($"Average Mark Of Student :{studentGrade.CalculateAverage()}");
Console.WriteLine($"Grade Of Student :{studentGrade.FindGrade()}");
/*Arrays arrays = new Arrays();
arrays.OneDimensional();
arrays.TwoDimensional();
arrays.Jaggerdarray();

/*
Employees employees = new Employees(111,"Abc","IT",10000);
Console.WriteLine($"Employee Id Is: {employees.Employeeid}");
Console.WriteLine($"Employee Name Is: {employees.Employeename}");
Console.WriteLine($"Employee Department Is: {employees.Department}");
Console.WriteLine($"Employee Basic Pay Is: {employees.Basicpay}");
Console.WriteLine($"Employee Net Salary Is: {employees.CalculateSalary()}");


/*Electricity electricity = new Electricity(1234,2400,25000,"ancd");
double billamount=electricity.CalculateBill();
Console.WriteLine($"Electricity bill is=- {billamount}");

Calculation calculation = new Calculation();
int numberone, numbertwo;
Console.WriteLine("Enter the two number");
numberone=Convert.ToInt32(Console.ReadLine());
numbertwo = Convert.ToInt32(Console.ReadLine());
double result=calculation.Addition(numberone,numbertwo);
Console.WriteLine($"Sum of Two Numbers is:- {result}");*/