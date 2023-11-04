using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal interface IEnrollable
    {
        public void CourseRegistration(int cid,int ssid);
        public void CourseWithdrawal(int eid);
    }
}
