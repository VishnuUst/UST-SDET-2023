using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(string? policyName, int? policyId, double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? PolicyName { get; set; }
        public int ? PolicyId { get; set; }
        public double PremiumAmount { get; set; }

        public double RenewPolicy(double newPremium)

        {
           PremiumAmount=newPremium;
            return PremiumAmount;
        }
        public double RenewPolicy()
        {
            double newPremium;
            newPremium = PremiumAmount + PremiumAmount * .1;
            return newPremium; 
        }
    }
}
