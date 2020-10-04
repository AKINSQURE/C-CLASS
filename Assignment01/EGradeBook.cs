using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    class EGradeBook
    {
        double gradeA;
       public double gradeB;
        double gradeC;
        double gradeD;

        public void AcceptDetails( )

        {
          //  double gradeA, gradeB, gradeC, gradeD;
           gradeB=40;
            Console.WriteLine(gradeB);
          //  double gradeC;
          //  double gradeD;
        }
        public double GetAverage(   )
        {
            gradeA = 90.2;gradeB = 50.6;gradeC = 60.3;gradeD = 41.8;
            return gradeA/4 + gradeB /4 + gradeC/4 + gradeD /4;
        }

        public bool GradeRange()
        {
            if (gradeA > gradeB && gradeA >gradeC && gradeA >gradeD )
            {
                return true ;
                
                //  Console.WriteLine("Gade A is the Highest score:" );
            }else if (gradeD <gradeA && gradeD <gradeB && gradeA<gradeD )
            {
                return true;
            }else 
            {
                return false;
               // Console.WriteLine(" Grade D is the lowest score:");
            }

        }
        public void   Display()
        {
            Console.WriteLine("GradeA: {0}", gradeA);
            Console.WriteLine("GradeB: {0}", gradeB);
            Console.WriteLine("GradeC: {0}", gradeC);
            Console.WriteLine("GradeD: {0}", gradeD);
            Console.WriteLine(" Average Grade: {0}", GetAverage( ));
            Console.WriteLine("Highest Grade is grade A: {0}", GradeRange ());
            Console.WriteLine("Lowest Grade is grade D: {0}", GradeRange());

        }
    }
 
}
