using CaseStudy;
using System.ComponentModel.Design;
using System.Threading.Channels;
using System.Xml.Serialization;
using static CaseStudy.MyExceptions.EnrollmentException;
using static CaseStudy.MyExceptions.MyProductException;
using static System.Reflection.Metadata.BlobBuilder;
class Program
{
    public delegate void DelegateOne(int id,int idtwo);
    public delegate void DelegateTwo(int cid);

    public static void Main(string[] args)
    {
        try
        {
            int option, option1;


            do
            {
                Console.WriteLine("****The India School****");
                Console.WriteLine("Choose The Option \n 1.Admin \n2.Student");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    int choice, choice1;
                    do
                    {
                        Console.WriteLine("Choose The option:\n1.Add Course\n2.View Report");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Course courses = new Course();
                                Console.WriteLine("Enter The Course Code");
                                courses.CourseCode = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Title");
                                courses.Title = Console.ReadLine();
                                Console.WriteLine("Enter the instructor");
                                courses.Instructor = Console.ReadLine();
                                Console.WriteLine("Enter the no of seats");
                                courses.MaxCount = Convert.ToInt32(Console.ReadLine());

                                Course.courses.Add(courses);
                                Console.WriteLine("Course Added Successfully");
                                break;
                            case 2:

                                break;
                            default:
                                Console.WriteLine("Invalid Option try again Later!!!");
                                break;
                        }
                        Console.WriteLine("Do You Want To Continue Press\n1.Yes\n2.No");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                    } while (choice1 == 1);

                }
                else if (option == 2)
                {
                    int soption, soption1;
                    do
                    {


                        Console.WriteLine("Choose The Menu You Want: \n 1.New Registration" +
                            "\n2.Enroll Course\n3.View Enrolled Course\n4.Withdraw Course \n 5.Exit");
                        soption = Convert.ToInt32(Console.ReadLine());
                        Student student = new Student();
                        Course courses = new Course();

                        switch (soption)
                        {

                            case 1:
                                Console.WriteLine("Enter The Student Id/User Id");
                                student.Id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Name");
                                student.StudName = Console.ReadLine();
                                Console.WriteLine("Enter The Email");
                                student.Email = Console.ReadLine();

                                Student.students.Add(student);
                                Console.WriteLine("Successfully Register!!!");
                                break;
                            case 2:


                                int cid;
                                if (Course.courses.Count != 0)
                                {
                                    Console.WriteLine("***List Of Course Availble In India School***");
                                    foreach (var course in Course.courses)
                                    {

                                        Console.WriteLine($"Course Code:{course.CourseCode}\tCourse Title:{course.Title}" +
                                            $"\tInstructor:{course.Instructor}\tNo:Of Seat:{course.MaxCount}\t");




                                    }
                                    Console.WriteLine("Enter  the Student Id");
                                    int sssid = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the course code You Want enroll");
                                    cid = Convert.ToInt32(Console.ReadLine());
                                    DelegateOne delegateOne = new DelegateOne(courses.CourseRegistration);
                                    delegateOne(sssid, cid);
                                }
                                else
                                {
                                    Console.WriteLine("No Courses Available!!!");

                                }


                                break;
                            case 3:

                                Console.WriteLine("Enter the Stude Id");
                                int esid = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Course Id");
                                int ccid = Convert.ToInt32(Console.ReadLine());

                                var courseObj = Course.courses.Find(x => x.CourseCode == ccid);
                                var EnrolObj = courseObj.Enrollments.Find(x => x.Id == esid);

                                if (EnrolObj != null)
                                {



                                    Console.WriteLine($"Course Code:{courseObj.CourseCode}\tTitle:{courseObj.Title}" +
                                        $"\tInstructor:{courseObj.Instructor}\tStudent Id:{EnrolObj.Id}\tStudent Name:{EnrolObj.StudName}\tEmail:{EnrolObj.Email}");


                                }
                                break;
                            case 4:
                                Console.WriteLine("Enter Your Course Code You Want Withdraw");
                                int eid = Convert.ToInt32(Console.ReadLine());
                                DelegateTwo delegateTwo = new DelegateTwo(courses.CourseWithdrawal);
                                delegateTwo(eid);
                                break;
                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid option try again!!!");
                                break;
                        }
                        Console.WriteLine("Do You Want To Continue press \n 1.Yes \n 2.No");
                        soption1 = Convert.ToInt32(Console.ReadLine());

                    } while (soption1 == 1);
                }

            } while (true);
        }
        catch (FullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(DuplicateException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
/*
try
{



    Customers customersOne = new Customers();
    customersOne.CustomerID = 1;
    customersOne.CustomerName = "Gokul";
    customersOne.CustomerEmail = "gokulv@ust";
    Customers.customers.Add(customersOne);
    Customers customerTwo = new Customers();
    customerTwo.CustomerID = 2;
    customerTwo.CustomerName = "vishnu";
    customerTwo.CustomerEmail = "vishnu@ust";
    Customers.customers.Add(customerTwo);
    Customers customerThree = new Customers();
    customerThree.CustomerID = 3;
    customerThree.CustomerName = "Shirin";
    customerThree.CustomerEmail = "shirin@ust";
    Customers.customers.Add(customerThree);
    Customers customerFour = new Customers();
    customerFour.CustomerID = 4;
    customerFour.CustomerName = "Jachithra";
    customerFour.CustomerEmail = "jachithar@ust";
    Customers.customers.Add(customerFour);
    Console.WriteLine("***FiowMart***");
    while (true)
    {
        Console.WriteLine("choose your option\n1.User\n2.Admin");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)

        {
            Console.WriteLine("Enter the customer id");
            int cusId = Convert.ToInt32(Console.ReadLine());
            if (Customers.customers.Find(x => x.CustomerID == cusId) == null)
            {
                Console.WriteLine("Customer not found!!!");
                break;
            }
            while (true)
            {
                Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
                int optionuser = Convert.ToInt32(Console.ReadLine());

                switch (optionuser)
                {

                    case 1:

                        Console.WriteLine("Enter Product Id ");
                        int productId = Convert.ToInt32(Console.ReadLine());
                        Customers customer1 = Customers.customers.Find(x => x.CustomerID == cusId);
                        if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                        {
                            if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                            {
                                Console.WriteLine("invalid product id try again!!!");
                            }
                            else
                            {
                                customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                                Console.WriteLine("Physical product is added to cart Sucessfully");
                            }
                        }
                        else
                        {
                            customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                            Console.WriteLine("Digital product added to cart Successfully");
                        }
                        break;
                    case 2:
                        Console.WriteLine("View Products");
                        if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                        {
                            Console.WriteLine("No Product Found !!!");
                        }
                        foreach (var item in DigitalProduct.Products)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                                item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                        }
                        foreach (var item in PhysicalProduct.Products)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                                "\tDimension:{5}", item.ProductId,
                                item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                        }
                        break;
                    case 3:
                        Customers customer = Customers.customers.Find(x => x.CustomerID == cusId);
                        if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
                        {
                            Console.WriteLine("no product found in cart");
                        }
                        else
                        {
                            foreach (var item in customer.orders)
                            {
                                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                                 item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                                item.PlacingOrder();
                                item.ProcessingPayment();
                                item.DeliveringProduct();

                            }
                            foreach (var item in customer.ordersphy)
                            {
                                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                               "\tDimension:{5}", item.ProductId,
                               item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                                item.PlacingOrder();
                                item.ProcessingPayment();
                                item.DeliveringProduct();
                            }
                            Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
                            int confirm = Convert.ToInt32(Console.ReadLine());
                            if (confirm == 1)
                            {
                                customer.confirmedorders.AddRange(customer.orders);
                                customer.orders.Clear();
                                customer.confirmedordersphy.AddRange(customer.ordersphy);
                                customer.ordersphy.Clear();
                                Console.WriteLine("order placed successfully");
                            }
                            else
                            {
                                Console.WriteLine("removing everything in cart");
                            }


                        }



                        break;
                    case 4:
                        Console.WriteLine("call this number for support 96456636727");
                        break;
                    case 5:
                        Customers customer2 = Customers.customers.Find(x => x.CustomerID == cusId);
                        if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
                        {
                            Console.WriteLine("no order details found");
                        }
                        else
                        {
                            Console.WriteLine("Orders are");
                            foreach (var item in customer2.confirmedorders)
                            {
                                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                                item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                            }
                            foreach (var item in customer2.confirmedordersphy)
                            {
                                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                               "\tDimension:{5}", item.ProductId,
                               item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("invalid input");

                        break;
                }

                Console.WriteLine("do you want to continue as user\n1.yes\n2.no");
                int optuser = Convert.ToInt32(Console.ReadLine());
                if (optuser == 1)
                {
                    continue;
                }
                else if (optuser == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }


        }

        else if (option == 2)
        {
            Console.WriteLine("choose option\n1.Add Product\n2.View report");
            int optionadmin = Convert.ToInt32(Console.ReadLine());
            if (optionadmin == 1)
            {
                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
                int optionProduct = Convert.ToInt32(Console.ReadLine());
                if (optionProduct == 1)
                {

                    Console.WriteLine("Enter Product id");
                    int productid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Product Name");
                    string? productName = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    double productCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the fileformat");
                    string? fileFormat = Console.ReadLine();
                    Console.WriteLine("Enter downloadLink");
                    string? downloadLink = Console.ReadLine();
                    Console.WriteLine("Enter the Quantity");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    
                    DigitalProduct digitalProduct = new DigitalProduct();
                    digitalProduct.ProductName = productName;
                    digitalProduct.ProductId = productid;
                    digitalProduct.FileFormat = fileFormat;
                    digitalProduct.DownloadLink = downloadLink;
                    digitalProduct.Price = productCost;
                    digitalProduct.ProductQuantity = quantity;
                    Product.AddProduct(digitalProduct);
                    DigitalProduct.Products.Add(digitalProduct);
                }
                else if (optionProduct == 2)
                {
                    Console.WriteLine("Enter Product id");
                    int productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name");
                    string? productName = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    double productCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Weight");
                    int weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter dimension");
                    string? dimension = Console.ReadLine();
                    Console.WriteLine("Enter the Quantity");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    PhysicalProduct physicalProduct = new PhysicalProduct();
                    physicalProduct.ProductName = productName;
                    physicalProduct.ProductId = productid;
                    physicalProduct.Price = productCost;
                    physicalProduct.Dimension = dimension;
                    physicalProduct.Weight = weight;
                    physicalProduct.ProductQuantity = quantity;


                    PhysicalProduct.Products.Add(physicalProduct);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        else
        {
            Console.WriteLine("invalid option");
        }
        Console.WriteLine("do you want to continue\n1.yes\n2.no");
        int opt = Convert.ToInt32(Console.ReadLine());
        if (opt == 1)
        {
            continue;
        }
        else if (opt == 2)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("invalid input");
        }

    }
}
catch(UserException ex)
{
    Console.WriteLine(ex.Message);
}






//int num = 1;
/*string? title;
int customerid;
string? customerName;
string? phonenumber;
string? orderdate;
int total;

do
{
    Console.WriteLine("\t*****Ashoka Book Store*****\t");
Console.WriteLine("1.Add Book\n2.Add Customer\n3.Place Order And Display Order\n4.Search Book\n5.Exit\t");
Console.WriteLine("Choose The Option");
int option = Convert.ToInt32(Console.ReadLine());

    BookType[] bookType = new BookType[]
          {
            new("The Hindu","Hari",20,1300,"yes","Fiction"),
         
            

          };

    switch (option)
    {
        case 1:
          
            Console.WriteLine("\t*****Book Added SuccessFully*****\t");
            foreach (BookType booktypes in bookType)
            {
                booktypes.DisplayDetails();
            }
            break;
        case 2:
            
            Console.WriteLine("Enter Customer Id");
            customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter Phonenumber");
            phonenumber = Console.ReadLine();

            Customer customer = new Customer(customerid, customerName, phonenumber);
            customer.DisplayCustomer();
            break;
        case 3:
           
            Console.WriteLine("Enter the Title Of Book");
            title = Console.ReadLine();


            if (bookType[0].Title.Equals(title))
            {
                foreach (var book in bookType)
                {
                    Console.WriteLine("Enter Order Date:");
                   orderdate=Console.ReadLine();
                    Console.WriteLine("Order Confirmed");
                    total = book.Price;
                    Order order = new Order(orderdate,total);

                    Console.WriteLine("\t******Order Details is*****\t");

                    order.DisplayOrder();
                    Console.WriteLine($"Book Title is:{book.Title}");
                    Console.WriteLine($"Book Price is:{book.Price}");
                    Console.WriteLine($"Book Type is:{book.Genre}");


                }
            }
            else
            {
                Console.WriteLine("No Book Available");
            }
           
            // order.DisplayOrderdetail();

           
            break;

        case 4:
            
            Console.WriteLine("Enter the Title Of Book");
            title = Console.ReadLine();
            foreach (var book in bookType)
            {
                if (book.Title.Equals(title))
                {
                    Console.WriteLine($"Book Title is:{book.Title}");
                    Console.WriteLine($"Book Price is:{book.Price}");
                    Console.WriteLine($"Book Availability is:{book.Availability}");
                    
                    
                   

                }

                else
                {
                    Console.WriteLine("No Book Available");
                }

            }


            

            
            break;
       
        case 5:
            
          
              Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    Console.WriteLine("Do you Want To Continue press1 or 0 for exit");
      num = Convert.ToInt32(Console.ReadLine());

} while (num!=0) ;





*/