using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Employees
    {
       private  int employeeid;
       private string? employeename, department;
       private double basicpay;
        private readonly int _bonus = 10;

        public Employees(int employeeid, string? employeename, string? department, double basicpay)
        {
            Employeeid = employeeid;
            Employeename = employeename;
            Department = department;
            Basicpay = basicpay;
        }

        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string? Employeename { get => employeename; set => employeename = value; }
        public string? Department { get => department; set => department = value; }
        public double Basicpay { get => basicpay; set => basicpay = value; }

        public int Bonus => _bonus;

        public double CalculateSalary()
        {
            double grosssalary,netsalary;
            double allowances = Basicpay * 0.3 + Basicpay * 0.2 + Basicpay * 0.15;
            grosssalary = Basicpay + allowances  ;
            double deductions = Basicpay * 0.1;
            netsalary = grosssalary - deductions;

            return netsalary ;
        }
    }
}
