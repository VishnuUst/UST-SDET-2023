﻿

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        CourseRegistration course = new CourseRegistration();
        int numberOfStudents = 5;

        List<Task> registrationTasks = new List<Task>();

        for (int i = 1; i <= numberOfStudents; i++)
        {
            string studentName = $"Student {i}";
            Task registrationTask = course.RegisterStudentAsync(studentName);
            registrationTasks.Add(registrationTask);
        }

        await Task.WhenAll(registrationTasks);

        Console.WriteLine($"Course registration completed. Total registered students: {course.GetRegisteredStudentCount()}");
    }
}
/*
class Program
{
    static async Task Main()
    {
        List<string> urls = new List<string>
        {
            "https://www.example.com",
            "https://www.google.com",
            "https://www.microsoft.com"
        };

        Console.WriteLine("Downloading web pages asynchronously...");

        List<Task<string>> downloadTasks = new List<Task<string>>();

        foreach (string url in urls)
        {
            downloadTasks.Add(DownloadWebPageAsync(url));
        }

        await Task.WhenAll(downloadTasks);

        foreach (Task<string> task in downloadTasks)
        {
            string content = await task;
            Console.WriteLine($"Downloaded {content.Length} bytes from a web page.");
        }

        Console.WriteLine("All web pages downloaded.");
    }

    static async Task<string> DownloadWebPageAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string content = await client.GetStringAsync(url);
            return content;
        }
    }
}

/*
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting the asynchronous operation...");

        // Perform an asynchronous operation
        await PerformAsyncOperation();

        Console.WriteLine("Asynchronous operation completed.");
    }

    static async Task PerformAsyncOperation()
    {
        // Simulate an asynchronous operation
        await Task.Delay(2000); // Delay for 2 seconds (simulating work)
        Console.WriteLine("Async operation is complete.");
    }
}

/*class Program
{
    static void Main()
    {
        CourseRegistration course = new CourseRegistration();
        int numberOfStudents = 5;

        List<Thread> studentThreads = new List<Thread>();

        for (int i = 1; i <= numberOfStudents; i++)
        {
            string studentName = $"Student {i}";
            Thread studentThread = new Thread(() => course.RegisterStudent(studentName));
            studentThreads.Add(studentThread);
            studentThread.Start();
        }

        foreach (Thread studentThread in studentThreads)
        {
            studentThread.Join();
        }

        Console.WriteLine($"Course registration completed. Total registered students: {course.GetRegisteredStudentCount()}");
    }
}

/*
class Program
{
    static void Main()
    {
        Warehouse warehouse = new Warehouse();

        Thread worker1 = new Thread(() => warehouse.AddBox(1));
        Thread worker2 = new Thread(() => warehouse.AddBox(2));

        worker1.Start();
        worker2.Start();

        worker1.Join();
        worker2.Join();

        Console.WriteLine("Work completed. Total boxes in the warehouse: " + warehouse.GetTotalBoxes());
    }
}

/*class ThreadExample
{
    static void Main()
    {
        // Create two threads
        Thread thread1 = new Thread(T1);
        Thread thread2 = new Thread(T1);
        Thread thread3 = new Thread(T1);
        // Start the threads
        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Wait for the threads to finish
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads have completed their work.");
    }

    static void T1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is working: " + i);
            Thread.Sleep(100); // Simulate some work
        }
    }
}
/*public delegate void DelegateOne(string msg);
public delegate void DelegateTwo(int n1,int n2);
public delegate int DelegateThree(int n1,int n2);   
class Program
{
    public static void Main(string[] args)
    {
        DelegateOne delegateOne = DelegateExamples.MethodDisplay;
        delegateOne("Hai Vishnu!!!");
        DelegateExamples delegateExamples = new();
        DelegateTwo delegateTwo = delegateExamples.Add;
       
        DelegateTwo delegateThree = delegateExamples.Sub;
        DelegateThree delegateThree1 = delegateExamples.Addr;
        Console.WriteLine(delegateThree1(20, 20));
        DelegateTwo delegateobj = delegateTwo + delegateThree-delegateThree;//MultiCasting symbol of delegate is +.
        delegateobj(10, 20);
       

    }
}

/*GenericsExample<int> genericsExample = new GenericsExample<int>(10,20);
Console.WriteLine($"{genericsExample.Value1}{genericsExample.Value2}");
GenericsExample<string> genericsExampleOne = new GenericsExample<string>("Hai","Vishnu");
Console.WriteLine($"{genericsExampleOne.Value1} {genericsExampleOne.Value2}");*/
/*GenericsExample<int> ga = new (new int[3] { 1, 2, 3 });
ga.Display();
wa
/*
FileOperations fileOperations = new FileOperations();
Console.WriteLine("***Create A file***");
fileOperations.CreateFile();
Console.WriteLine("***Write Data To File***");
fileOperations.WriteData();
Console.WriteLine("Succeessfully Writed go and check the file the data avail or not!!!");
Console.WriteLine("***Read Data From First Created File***");
fileOperations.ReadData();
Console.WriteLine("**Copy And Move Operation**");
//fileOperations.CopyFile();
Console.WriteLine("Success");
Console.WriteLine("**File Deletion**");
fileOperations.DeleteFile();
Console.WriteLine("Successfully Deleted!!!");
/*
ExceptionHandling exceptionHandling = new ExceptionHandling(10,150);

try
{
    exceptionHandling.NumCheck();


}
catch (Num1Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    exceptionHandling.NumcheckOne();
}
catch(Num2Exception ex)
{
    Console.WriteLine(ex.Message);
}
/*try
{
    exceptionHandling.NumCheck();
  

}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}*/
/*
try
{
    exceptionHandling.Divide();
}
catch (ArithmeticException ex)
{
    Console.WriteLine(MyException.exMessageList["One"]);
   
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine(MyException.exMessageList["Two"]);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
 finally
{
    Console.WriteLine("Successfully Completed !!!");

}
/*NonGeneric nonGeneric = new NonGeneric();
nonGeneric.ArrayList();

nonGeneric.StackHandling();
nonGeneric.QueueHandling();
nonGeneric.HashHandling();
nonGeneric.SortedListHandling();
Generic generic = new Generic();
generic.ListHandling();
generic.DictionaryHandling();
generic.StackHandling();
generic.QueueHandling();
/*BankDetails bankDetails = new BankDetails(1234,11234567860L,"Vishnu","InActive");*/
/*BankDetails bankdetailsone = new BankDetails();*/
/*BankDetails bankDetailsNew = new BankDetailsNew(123, 12345677L, "Vishnu", "Active");
bankDetailsNew.WelcomeMessage();
Console.WriteLine("1.CustomerId\n2.AccountNumber\n3.CustomerName");
int choice;
Console.WriteLine("Choose One Option");
choice = Convert.ToInt32(Console.ReadLine());
switch(choice)
{
    case 1:
        Console.WriteLine("Enter The CustomerId");
        int customerid = Convert.ToInt32(Console.ReadLine());
        bankDetailsNew.GetAccountDetails(customerid);
        bankDetailsNew.ExitMessage();
        break;
    case 2:
        Console.WriteLine("Enter The AccountNumber");
        long accountnumber = Convert.ToInt64(Console.ReadLine());
        bankDetailsNew.GetAccountDetails(accountnumber);
        bankDetailsNew.ExitMessage();
        break;
    case 3:
        Console.WriteLine("Enter the CustomerName Name");
        string?customername= Console.ReadLine();
        bankDetailsNew.GetAccountDetails(customername);
        bankDetailsNew.ExitMessage();
        break;
    default:
        Console.WriteLine("INVALID ENTRY TRY AGAIN LATER!!!");
        break;

}
/*Doctor doctor = new Doctor();
doctor.AddNewDoctor();
Console.WriteLine("***New Docotr Details***");
doctor.DisplayDoctor();
doctor.ModifyDoctor();
Console.WriteLine("***Modified Doctor Details***");
doctor.DisplayDoctor();
doctor.BookAppointment(1, "VIBIN");
Console.WriteLine("Appointment deleted details");
doctor.DeleteAppointment(1);
/*IDoctor doctor1 = new Doctor();
doctor1.AddNewDoctor();

/*ElectricalVehicle ev=new ElectricalVehicle();
ev.VehicleNumber=1;
ev.Brand = "xx";
ev.Model = "AA";
ev.Dipslay();
Console.WriteLine(ev.SetTypeForVehicle());
PowerVehicle power=new PowerVehicle();
power.VehicleNumber=1;
power.Brand = "BB";
power.Model = "cc";
power.Dipslay();
Console.WriteLine(power.SetTypeForVehicle());


/*Console.WriteLine("Chose Any One Options");
Console.WriteLine("1.Teaching Staff\n2.Non Teaching Staff");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff teachingStaff = new TeachingStaff();
        Console.WriteLine("****Teaching Staff Details****");
        teachingStaff.StaffId = 1;
        teachingStaff.StaffName = "Test";
        teachingStaff.StaffDepartment = "MCA";
        teachingStaff.Specialization = "Java";
        teachingStaff.Semester = 3;
        teachingStaff.DisplayStaffDetails();
        teachingStaff.DisplayTeachingStaffDetails();
        break;
     case 2:
        NonTeachingStaff nonTeachingStaff = new NonTeachingStaff();
        Console.WriteLine("***Non Teaching Staff Details***");
        nonTeachingStaff.StaffId = 2;
        nonTeachingStaff.StaffName = "Testtwo";
        nonTeachingStaff.StaffDepartment = "Cleaning";
        nonTeachingStaff.Responsibilities = "cleaning Cafteria";
        nonTeachingStaff.Experience = 3;
        nonTeachingStaff.DisplayStaffDetails();
        nonTeachingStaff.DisplayNoonTeachingStaff();


        break;
      default: Console.WriteLine("Invalid Options!!!");
        break;



}


/*StudentMarks studentMarks = new StudentMarks();*/
/*StudentGrade studentGrade = new StudentGrade();
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