﻿using Assignment;
using Assignment_2_oct19_Q1;
using Assignments;
using System.Threading.Channels;
using static Assignments.ExceptionHandling.MyException;
FamilyMember grandparent = new FamilyMember("Grandparent", 70);
FamilyMember parent1 = new FamilyMember("Parent 1", 40);
FamilyMember parent2 = new FamilyMember("Parent 2", 38);
FamilyMember child1 = new FamilyMember("Child 1", 12);
FamilyMember child2 = new FamilyMember("Child 2", 8);

grandparent.AddChild(parent1);
grandparent.AddChild(parent2);
parent1.AddChild(child1);
parent2.AddChild(child2);

FamilyTree familyTree = new FamilyTree(grandparent);
familyTree.DisplayFamilyTree();

/*ToDo toDo = new ToDo(1,"SDET","Completed");
ToDo toDo1 = new ToDo(2, "c#", "Pending");

ToDo.toDoList.Add(toDo);
ToDo.AddTodo(toDo);
ToDo.AddTodo(toDo1);
ToDo.updateList(2,"Completed");
ToDo.Display("Completed");
ToDo.Remove(1);




/*
TourPackage package = new TourPackage(1, "kochi", "12-11-2024", 1300);
TourPackage package1 = new TourPackage(2, "Kolam", "12-10-2024", 1200);
TourPackage package2 = new TourPackage(3, "kannur", "2-2-2023", 1100);

TourPackage.TourPackages.Add(package1);
TourPackage.TourPackages.Add(package2);
TourPackage.TourPackages.Add(package);


Thread thread = new Thread(TourPackage.HotelReservation);

Thread thread1 = new Thread(TourPackage.HotelReservation);

thread1.Start();
thread1.Join();
thread.Start();
/*Hotel hotel = new Hotel("name", 4, "ars", "adfgas", 45);
Hotel hotel1 = new Hotel("nam3", 6, "ars", "adfgas", 45);
Hotel hotel2 = new Hotel("name6", 17, "ars", "adfgas", 45);

await hotel.HotelBookingig(6, hotel);
await hotel1.HotelBookingig(5, hotel1);
await hotel2.HotelBookingig(5, hotel2);
/*
int choice, option;
do
{
    Console.WriteLine("***Hormuz Nest***");
    Console.WriteLine("1.Add Place\n2.View Top Place\n3.View Place By Price\n4.FilterPlaceByLocation\n5.Exit");
    Console.WriteLine("Choose The Menu You Want");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

        Console.WriteLine("**HormuZ Nest**");
        Console.WriteLine("Enter The Place Name");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter The Location Name");
        string? location = Console.ReadLine();
        Console.WriteLine("Enter the Rating Of The Place");
        double rating = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Cost");
        double price = Convert.ToDouble(Console.ReadLine());
        TourismDestinationOne tourismDestination = new TourismDestinationOne(name, location, rating,price);
        TourismDestinationOne.tourismDestinationOnes.Add(tourismDestination);
    
        break;
        case 2:
            Console.WriteLine("Enter The Rating Range You Want");
            double rates = Convert.ToDouble(Console.ReadLine());
            TourismDestinationOne.TopRated(rates);
        break;
      case 3:
            TourismDestinationOne.ViewDataPricePerNight();
            break;
      case 4:
            Console.WriteLine("Enter The Location You Want Visit");
            string loc = Console.ReadLine();
            TourismDestinationOne.FilterPlaceByCityOrRegion(loc);
            break;
      case 5:
          Environment.Exit(0);
            break;
      default:
            Console.WriteLine("Invalid Option!!!");
            break;
    }
    Console.WriteLine("Do You Want To CONTINUE PRESS\n 1.Yes\n 2.No");
    option = Convert.ToInt32(Console.ReadLine());

}while(option==1);
/*class Program(();
{
   / public delegate string DelegateMessageOne(string msg);
    public delegate string DelegateMessageTwo(string msg);
    public static void Main(string[] args)
    {
        HotelEvent hotelEvent = new("Dj", "Trivandrum", "12.00:12-10-2023", 4);
        DelegateMessageOne delegateMessageOne = HotelEvent.EventRegistration;
        if(hotelEvent != null) 
        {
            Console.WriteLine(delegateMessageOne($"Hai {hotelEvent.EventName} is Successfully Registered the event on {hotelEvent.EventDate}"));
        }
        else
        {
            Console.WriteLine(delegateMessageOne("Unsuccessfully registered"));
        }
        HotelEvent hotelEventone = new("Hallowing", "Kollam", "12.0013-10-2023", 6);

        DelegateMessageTwo delegateMessageTwo = HotelEvent.EventRegistration;
        if (hotelEventone != null)
        {
            Console.WriteLine(delegateMessageTwo($"Hai {hotelEventone.EventName} is Successfully Registered the event on {hotelEventone.EventDate}"));
        }
        else
        {
            Console.WriteLine(delegateMessageTwo("Unsuccessfully registered"));
        }
    }
}

/*
class Program
{
   public delegate double DelegateOne(Employees employee);
    public delegate double DelegateTwo(Employees employeeone);

    public static void Main(String[] args)
    {
        DelegateExample delegateExample = new DelegateExample();
        Employees employee = new(1, "Vishnu", 4);
        Employees employeeone = new(2, "Gokul", 5);
        DelegateOne delegateOne = Employees.BonusCalculation;
        DelegateTwo delegateTwo = Employees.BonusCalculation;
        Console.WriteLine($"Employee Name:{employee.EmployeeName}\nPerformance Rating:{employee.PerformanceRange}\nBonus Amount:{delegateOne(employee) }");
        Console.WriteLine($"Employee Name:{employeeone.EmployeeName}\nPerformance Rating:{employeeone.PerformanceRange}\nBonus Amount:{delegateTwo(employeeone)}");

    }
}


Inventory<string> inventory = new Inventory<string>();
int choice, option;
do
{
    Console.WriteLine("Choose The Menu");
    Console.WriteLine("1.Add Product\n2.Update Product\n3.RemoveProduct\n4.Search ProductById\n5.Search Product By Name");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter The Product Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The ProductName");
            string? productname = Console.ReadLine();
            Console.WriteLine("Enter The Price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity in stock");
            int qty = Convert.ToInt32(Console.ReadLine());
            inventory.AddProduct(new Products<string>(id, productname, price, qty));
            break;
        case 2:
            Console.WriteLine("Enter the product id Do You want update");
            int proid = Convert.ToInt32(Console.ReadLine());
            var prId = inventory.FindProductById(proid);
            if (prId != null)
            {
                Console.WriteLine("Enter the Product Name");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter the price");
                double pric = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the qty");
                int qt = Convert.ToInt32(Console.ReadLine());
                inventory.UpdateProduct(proid, name, pric, qt);
                Console.WriteLine("Successfully Updated");

            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }

            break;
        case 3:
            Console.WriteLine("Enter the product Id Do You Want Delete");
            int ids = Convert.ToInt32(Console.ReadLine());
            var data = inventory.FindProductById(ids);
            if (data != null)
            {
                inventory.DeleteProduct(ids);
                Console.WriteLine("Product Deleted Success!!!!");
            }
            else
            {
                Console.WriteLine("No Product available!!!");
            }
            break;
        case 4:
            Console.WriteLine("View Product BY Id");
            Console.WriteLine("Enter The Product Id");
            int pid = Convert.ToInt32(Console.ReadLine());
            Products<string> pro = inventory.FindProductById(pid);
            if (pro != null)
            {
                Console.WriteLine($"Product Id:{pro.ProductId}\nProduct Name:{pro.ProductName}" +
                    $"\nPrice:{pro.Price}\nQuantity:{pro.QuantityInStock}");
            }
            else
            {
                Console.WriteLine("No Product Available");
            }



            break;
        case 5:
            Console.WriteLine("Search Product By Name");
            string? proname = Console.ReadLine();
            List<Products<string>> dat = inventory.FindProductByName(proname);
            if (dat != null)
            {
                foreach (Products<string> p in dat)
                {
                    Console.WriteLine($"Product Id:{p.ProductId}\nProduct Name:{p.ProductName}" +
                    $"\nPrice:{p.Price}\nQuantity:{p.QuantityInStock}");
                }
            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option!!!!");
            break;
    }
    Console.WriteLine("Do you want to continue \n1. Yes \n2.No");
    option = Convert.ToInt32(Console.ReadLine());

} while (option == 1);

try
{
    // Patient.AddPatient(1, "Vishnu", 25, "Cholestrol");
    MedicalRecord medicalRecord = new MedicalRecord(12, 12, "Hari", 24, "Hl", 300);


    MedicalRecord.AddMedicalRecord(medicalRecord);


    MedicalRecord.DisplayMedicalRecords();

}
catch(InvalidPatientException ex)
{
    Console.WriteLine(ex.Message);
}
catch(InvalidMedicalRecordException ex)
{
    Console.WriteLine($"{ex.Message}");
}

Console.WriteLine("Enter the room number You want");
int roomNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the room type You want(double/single");
string? type = Console.ReadLine();
HotelRoom hotelRoom = new HotelRoom(roomNumber,type,true);
RoomReservation<HotelRoom> roomReservation = new RoomReservation<HotelRoom>();
roomReservation.AddRoom(hotelRoom);
Console.WriteLine("Room Details");
foreach (var room in RoomReservation<HotelRoom>.reservations)
{
    Console.WriteLine($"Room Number{room.RoomNumber}\nRoom Type:{room.RoomType}");
}
Console.WriteLine("Enter The Room Number");
int roomnumbers = Convert.ToInt32(Console.ReadLine());
//var data =RoomReservation<HotelRoom>.reservations.Find(x=>x.RoomNumber==roomnumbers);
HotelRoom data=RoomReservation<HotelRoom>.reservations.Find(x=>x.RoomNumber==roomnumbers);
if(data!=null)
{
    
   roomReservation.RemoveRoom(data);
    Console.WriteLine("Removed Success");
}
else
{
    Console.WriteLine("No Room found to remove!!!");
}

int choice;
int option;

do
{
    Console.WriteLine("1.Add Medical History 2.Search and view record B");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the Record Id");
            int recordId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Patient Id");
            int patientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Description");
            string? description = Console.ReadLine();
            Console.WriteLine("Enter The Date");
            string? date = Console.ReadLine();
            MedicalHistory medical = new MedicalHistory(recordId, patientId, description, date);
            MedicalHistory.AddMedicalHostory(medical);
            medical.WriteData();
            break;
        case 2:
            Console.WriteLine("Search Patient By Id");
            int pId = Convert.ToInt32(Console.ReadLine());
            MedicalHistory.ReadDataById(pId);
            break;



    }
    Console.WriteLine("Do U Want To Continue");
    option= Convert.ToInt32(Console.ReadLine());

}while (option == 1);

do
{
    Console.WriteLine("1.Add Patient\n 2.View Patient");
    Console.WriteLine("Enter The choice");
    choice = Convert.ToInt32(Console.ReadLine());
   
    switch (choice)
    {
        case 1:
           
            Console.WriteLine("Enter The Patient ID");
            int patientId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Patient Name");
            string? patientname = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Diagnose");
            string? diagnose = Console.ReadLine();
            try
            {
                Patient patient = new Patient(patientId, patientname,age,diagnose);
                Patient.AddPatient(patient);
                patient.WriteData();
                
            }
            catch (InvalidPatientException ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            break;
        case 2:
            Patient.ReadData();
            break;

    }
    Console.WriteLine("Do you want to continue press one for Continue two for exit");
    option=Convert.ToInt32(Console.ReadLine());
} while (option== 1);



CallRecord callRecordOne = new(123, 99999, 12.01);
CallRecord callRecordTwo = new(124, 99999, 11.2);
CallRecord callRecordThree = new(125, 9898989, 1.02);
CallRecord.callRecords.Add(callRecordOne);
CallRecord.callRecords.Add(callRecordTwo);
CallRecord.callRecords.Add(callRecordThree);
Console.WriteLine("***Search Call History By PhoneNumber");
int phonenumber = Convert.ToInt32(Console.ReadLine());
CallRecord.SearchCallRecordByPhoneNumber(phonenumber);
CallRecord.DisplayCountOfCallHistory();

/*Customer customerOne = new(101, "Shirin", 94949494, 120000);
Customer customerTwo = new(102, "Jachithra", 232323, 100000);
Customer customerThree = new(103, "Gokul", 12121212, 50000);
Customer.customer.Add(customerOne);
Customer.customer.Add(customerTwo);
Customer.customer.Add(customerThree);
Customer.DisplayAllCustomer();
Console.WriteLine("**Search Customer By PhoneNumber**");

int phonenumber = Convert.ToInt32(Console.ReadLine());
Customer.DisplayCustomerByPhoneNumber(phonenumber);

/*string? policyName;
int policyId;
double premiumAmount;
Console.WriteLine("Enter the policyName");
policyName = Console.ReadLine();
Console.WriteLine("Enter the policyid");
policyId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the premiumAmount");
premiumAmount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Policy Details");
Console.WriteLine($"Policy name:{policyName}\nPolicy Id:{policyId}\nPremiumAmount:{premiumAmount}\n");
Console.WriteLine("Updated Details");
Console.WriteLine("Enter New Premium Amount");
double newpremium = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("***Updated Details***");
InsurancePolicy insurancePolicy = new InsurancePolicy(policyName, policyId, premiumAmount);
Console.WriteLine($"Policy name:{policyName}\nPolicy Id:{policyId}\noldPremiumAmount:{premiumAmount}\nNewPremium:{insurancePolicy.RenewPolicy(newpremium)}");
Console.WriteLine("***Reniewal Details");
Console.WriteLine($"Policy name:{policyName}\nPolicy Id:{policyId}\noldPremiumAmount:{premiumAmount}\nNewPremium:{insurancePolicy.RenewPolicy()}");

CarInsurance carInsurance = new CarInsurance();
Console.WriteLine("***New India CarInsurance***");
Console.WriteLine("Enter The PolicyName");
carInsurance.PolicyName = Console.ReadLine();
Console.WriteLine("Enter The PolicyId");
carInsurance.PolicyId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Premium Amount");
carInsurance.PremiumAmount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter The Car Type(1.Fully\n,2.Semi)\n");
carInsurance.CarType = Console.ReadLine();




Console.WriteLine("***CarInsurance Policy Details***");
Console.WriteLine($"Policy Name:{carInsurance.PolicyName}\nPolicy Id:{carInsurance.PolicyId}\nPremium Amount:{carInsurance.PremiumAmount}\nCar Type:{carInsurance.CarType}\n Sum Insured:{carInsurance.CalculatePremiumAmount()}");
LifeInsurance lifeInsurance = new LifeInsurance();
Console.WriteLine("***NewIndiaLifeInsurance***");
Console.WriteLine("Enter The PolicyName");
lifeInsurance.PolicyName = Console.ReadLine();
Console.WriteLine("Enter The PolicyId");
lifeInsurance.PolicyId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Premium Amount");
lifeInsurance.PremiumAmount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter The Age\n");
lifeInsurance.age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("***LifeInsurance Policy Details***");
Console.WriteLine($"Policy Name:{lifeInsurance.PolicyName}\nPolicy Id:{lifeInsurance.PolicyId}\nPremium Amount:{lifeInsurance.PremiumAmount}\nAge:{lifeInsurance.age}\n Sum Insured:{lifeInsurance.CalculatePremiumAmount()}");


Rectangle rectangle = new Rectangle(12,12);
Circle circle = new Circle(10);
rectangle.Draw();
circle.Draw();
/*Employee employee = new Employee(1, "Vishnu", "T", 2);
employee.DisplayInfo();
string? productName;



ElectronicsProduct electronicsProduct = new ElectronicsProduct("MixerGrinder",15600,2,10);
Console.WriteLine("***Electronic Product Details***\n");
Console.WriteLine($"ProductName is:{electronicsProduct.Productname}\nPrice:{electronicsProduct.Price}" +
    $"\nQuantity:{electronicsProduct.Quantity}\n");
electronicsProduct.DisplayWarrantyPeriod();
Console.WriteLine($"Total Value :{electronicsProduct.ProductValue()}\n\n");

DigitalProduct digitalProduct = new DigitalProduct ("SmartWatch","Mp4",1999,2,3);
Console.WriteLine("***Digital Product Details***\n");
Console.WriteLine($"ProductName is:{digitalProduct.Productname}\nPrice:{digitalProduct.Price}" +
    $"\nQuantity:{digitalProduct.Quantity}\n");
digitalProduct.DisplayWarrantyPeriod();
Console.WriteLine($"Total Value :{digitalProduct.ProductValue()}\n\n\n");
digitalProduct.DisplayFileFormat();
Console.WriteLine("***Clothing ProductDetails***\n");
ClothingProduct clothingProduct = new ClothingProduct("Tshirt", "medium", 500, 2);
Console.WriteLine($"Product Name:{clothingProduct.Productname}\nPrice:{clothingProduct.Price}\nQuantity:{clothingProduct.Quantity}");
clothingProduct.DisplayClothingProductSize();
Console.WriteLine($"Total Value Of Product:{clothingProduct.ProductValue()}");





Product[] products = new Product[10];
products[0] = new("Bread", 120, 3);
products[1] = new("Sandwitch", 300, 5);
products[2] = new("Tomatoo", 700, 10);
foreach (Product product in products)
{
    Console.WriteLine($"The Product Name is : {product.Productname}");
    Console.WriteLine($"The Product Price is : {product.Price}");
    Console.WriteLine($"The Product Quantity is : {product.Quantity}");
    Console.WriteLine($"The Total Product Value: {product.ProductValue()}");



}Students[] students = new Students[]
{

 new("Abc", new double[] {89,90,80}, 'A'),
 new("Abz", new double[] {79,50,80}, 'B'),
 new("Abcd", new double[] {89,10,80}, 'C'),



};
foreach(Students student in students)
{
    Console.WriteLine($"Student Name is :{student.Name}");
    Console.WriteLine($"Student Grade is: {student.Grade}");
    double[] marks = new double[3];
    double total = 0;
    Console.WriteLine("Marks of student is:\t");
    for (int i = 0; i < marks.Length; i++)
    {
        marks[i] = student.Marks[i];
        total = total + marks[i];
        Console.WriteLine(marks[i]);
    }
    Console.WriteLine($"Total Marks is:{total}");
    Console.WriteLine($"Average Marks is: {student.CalculateAverage()}");
    Console.WriteLine(student.GetMarksSummary());
}


Console.WriteLine("Enter the Name");
string name=Console.ReadLine();
Console.WriteLine("Enter the marks");
int markone=Convert.ToInt32(Console.ReadLine());
int marktwo=Convert.ToInt32(Console.ReadLine());
int markthree=Convert.ToInt32(Console.ReadLine());
CalculateAverage calculateAverage=new CalculateAverage(markone, marktwo, markthree,name);
Console.WriteLine($"Name Of Student is: {name}");
Console.WriteLine($"Average Mark is:{calculateAverage.CalculateAverageMark()}");
Console.WriteLine($"Total Mark is:{calculateAverage.TotalMark()}");
Console.WriteLine($"Grade is:{calculateAverage.GetGrade()}");

*/