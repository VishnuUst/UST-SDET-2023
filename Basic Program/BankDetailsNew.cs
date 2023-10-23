using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int customerId, long accountNumber, string? customerName, string? status):base(customerId, accountNumber, customerName, status) 
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Status = status;
        }

        public int CustomerId { get; set; }

        public long AccountNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? Status { get; set; }
        public override void WelcomeMessage()
        {
            Console.WriteLine($"Welcome to ICICI BANK {CustomerName}");

        }
        public override void ExitMessage()
        {
            Console.WriteLine("Completed!!!");
        }
    }
}
