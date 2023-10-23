using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_10_23
{
    internal class CalculateAverage
    {
        int  markone,marktwo,markthree,average,totalmark;
        string? name;

        public CalculateAverage(int markone, int marktwo, int markthree, string? name)
        {
            this.markone = markone;
            this.marktwo = marktwo;
            this.markthree = markthree;
            this.name = name;
        }

        public double CalculateAverageMark()
        {

            double average;
            average=(markone+marktwo+markthree)/2;
            return average;

        }
        public double TotalMark()
        {
            double total;
            total=markone+marktwo+markthree;
            return total;
        }
        public char GetGrade()
        {
            double average=CalculateAverageMark();
            if(average<=50)
            {
                return 'E';
            }
            else if(average>50 && average<=60)
            {
                return 'D';
            }

           else if(average>60 && average<=70)
            {
                return 'C';
            }
            else if(average>70 && average<=80)
            {
                return 'B';
            }
            else
            {
                return 'A';
            }


        }
    }
}
