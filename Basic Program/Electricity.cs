using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Electricity
    {
       int consumernumber, previousreading, currentreading;
        string? consumername;

        public Electricity(int consumernumber, int previousreading, int currentreading, string? consumername)
        {
            this.consumernumber = consumernumber;
            this.previousreading = previousreading;
            this.currentreading = currentreading;
            this.consumername = consumername;
        }

        /* public Electricity()
{
    consumernumber = 12435; 
    previousreading = 900;
    currentreading =1200;
    consumername = "Abcd";
}*/

        public double CalculateBill()
        {
            double billamount = 0;
            int reading = currentreading - previousreading;
            if(reading<=100)
            {
                billamount = reading * 100;
            }
            else if(reading<=200 && reading>=101)
            {
                billamount = (100 * 2) + ((reading - 100) * 2.5);
            }
            else if (reading <= 401 && reading >= 201)
            {
                billamount = (100 * 2) + (100*2.5)+ ((reading - 200) * 3.5);
            }
            else
            {
                billamount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 4.5);
            }
            

            return billamount;
        }

    }
}
