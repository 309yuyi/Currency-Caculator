using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace current_caculator
{

    public class caculate
    {
        public static  double current1( double U, double R1, double R2, double R3, double R4)
        {
            double R = R2 * R4 / (R2 + R3 + R4) + 1 / (1 / (R1 + R2 * R3 / (R2 + R3 + R4)) + (R2 + R3 + R4) / (R3 * R4));
            double I = U / R;
            return I;
        }



        public static double current2(double U, double R1, double R2, double R3, double R4)
        {
            double R = R1 * R3 / (R1 + R2 + R3) + 1 / (1 / R4 + R1 * R2 / (R1 + R2 + R3) + (R1 + R2 + R3) / (R2 * R3));
            double I = U / R;
            return I;
        }
       
    }
}
