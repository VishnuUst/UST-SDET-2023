using Assignment;
using Assignments;
using System.Threading.Channels;
using static Assignments.ExceptionHandling.MyException;
/*try
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
}*/
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

/*do
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