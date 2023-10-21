using CaseStudy;
using static System.Reflection.Metadata.BlobBuilder;

int num = 1;
string? title;
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





