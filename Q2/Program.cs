using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            double thbConvert = 0.00;
            double thb;
            int chktypeErr = 0;
            Convert convrt = new Convert();
            Console.Write("Input :Number on THB ");
            string strthb = Console.ReadLine();
            Console.Write("      :String:Convert To Currency Type ");
            try
            {
                var type = Console.ReadLine();
                thb = Double.Parse(strthb);
                if (type.ToUpper() == "WON")
                {
                    thbConvert = convrt.ConvertWON(thb);
                }
                else if (type.ToUpper() == "USD")
                {
                    thbConvert = convrt.ConvertUSD(thb);
                }
                else if (type.ToUpper() == "YEN")
                {
                    thbConvert = convrt.ConvertYEN(thb);
                }
                else
                {
                    chktypeErr = 1;
                }

                if (chktypeErr == 1)
                {
                    Console.WriteLine("Output:String:System is not Convert Type " + type);
                }
                else
                {
                    Console.WriteLine("Output:String:Number of converted " + thbConvert + " " + type);
                }
                Console.Read();
            }
            catch (Exception ex){
                Console.WriteLine(ex);
                Console.Read();
            }
            
        }
    }
}
