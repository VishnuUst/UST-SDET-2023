using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : InsurancePolicies

    {
        public int age { get; set; }

        public override double CalculatePremiumAmount()
        {
            if(age>=70)
            {
                return PremiumAmount * .1;
            }
            else if(age>=18 && age<=69)
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
