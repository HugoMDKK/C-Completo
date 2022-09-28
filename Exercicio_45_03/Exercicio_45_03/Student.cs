using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_45_03
{
    internal class Student
    {
        public String Name;
        public double A;
        public double B;
        public double C;

        public double OverallNote()
        {
            return A + B + C;
        }

       
       public bool Approved()
        {
            if (OverallNote() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double RemainingNote()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - OverallNote();
            }
        }
    }
}
