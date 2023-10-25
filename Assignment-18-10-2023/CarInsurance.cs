using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : InsurancePolicies
    {
        public string? CarType { get; set; }
        
        public override double CalculatePremiumAmount()
        {
           if (CarType == "FullOption")
            {
                return PremiumAmount * .1;
            }
           else if(CarType =="SemiOption")
            {
                return PremiumAmount * .2;
            }
           else
            {
                return PremiumAmount;
            }
        }
    }
}
