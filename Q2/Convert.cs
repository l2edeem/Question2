using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Convert
    {
        public double ConvertWON(double thb)
        {
            double result = thb*33.72;
            return result;
        }
        public double ConvertUSD(double thb)
        {
            double result = thb * 0.028;
            return result;
        }
        public double ConvertYEN(double thb)
        {
            double result = thb * 3.4;
            return result;
        }
    }
}
