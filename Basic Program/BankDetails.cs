using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class BankDetails
    {
        public BankDetails() 
        {
            CustomerId = 0;
            AccountNumber = 1234567655L;
            CustomerName = "Gokul";
            Status = "Active";
        }

        public BankDetails(int customerId, long accountNumber, string? customerName)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Status = "active";
        }

        public BankDetails(int customerId, long accountNumber, string? customerName, string? status)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Status = status;
        }

        public int CustomerId {  get; set; }

        public long AccountNumber { get; set; }
        public string? CustomerName {  get; set; }
        public string? Status {  get; set; }
        public void GetAccountDetails(int customerId)
        {
            if(CustomerId == customerId)
            {
                Console.WriteLine("***Customer Details***");
                Console.WriteLine($"Account Number is:{AccountNumber}\nName:{CustomerName}\nStaus:{Status}");

            }
            else
            {
                Console.WriteLine("Customer Id Not Exist!!!");
            }
        }
        public void GetAccountDetails(long accountnumber)
        {
            if (AccountNumber == accountnumber)
            {
                Console.WriteLine("***Customer Details***");
                Console.WriteLine($"Customer Id is:{CustomerId}\nName:{CustomerName}\nStaus:{Status}");

            }
            else
            {
                Console.WriteLine("Customer Id Not Exist!!!");
            }
        }
        public void GetAccountDetails(string?customername)
        {
            if (CustomerName == customername)
            {
                Console.WriteLine("***Customer Details***");
                Console.WriteLine($"Customer Id is:{CustomerId}\nAccount Number is:{AccountNumber}\nStaus:{Status}");

            }
            else
            {
                Console.WriteLine("Customer Id Not Exist!!!");
            }
        }

    }
}
