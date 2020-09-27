using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
public class MathLibrary
    {

         public   static double Add(List<double> values)
                        {
                            double result = 0;
                            foreach (var value in values)
                            {
                                result = result + value;
                            }
         // WriteAdditionResult(result);
                            return result;
                        }


        static void WriteAdditionResult(double res)
        {
            Console.WriteLine(res);
        }


    }
}
