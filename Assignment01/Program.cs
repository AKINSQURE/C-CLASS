using System;
using System.Collections.Generic;

namespace Assignment01
{
    class Program
    {
        static string test = "bola";
        string taju = "fadekemi";
        string tau = "tau chi";
        string tu = "tunde";
        const string val = "rgrhrgrg";
        static readonly string val2 = "fgjfhjfdj";
         readonly string val3= "fgjfhjfdj";
           
        static void Main(string[] args)
        {
            //adonly val2 ;
            var bb = new Program();
double ee= MathLibrary.Add(new List<double> { 23.2, 47, 46, 23 });
            Console.WriteLine(ee);
           ///th.
            //Console.WriteLine(ch("shupo"));
            //Console.WriteLine(ch("tobi"));
            //Console.WriteLine(ch("dapo"));
            //Console.WriteLine(ch("tunde"));

            bool bola=12>34;
            Console.WriteLine(ch(bola));
            Console.WriteLine(ch(true));

            // Array bolaw= new Array[2];
            List<string> ddd =new List<string>();
            ddd.Add("bolaji");
            ddd.Add("bola");
            ddd.Add("debi");
            ddd.Add("tayo");

            List<string> d = new List<string> { "bolaji", "bola", "debi", "tayo" };
            List<string> dddds= new List<string>(){"olaji", "bola", "debi", "tayo" };
            string bimbo = "tambolo";

            for (int i = d.Count-1;i>=0;i-=2)
            {
                Console.WriteLine(ddd[i]);
            }

            foreach (var item in bimbo)
            {
                Console.WriteLine(item);
            }
            {
                
            }

            char singleb = bimbo[0];
            char lastchar = bimbo[6];
            char sastchar = bimbo[5];
            Console.WriteLine(lastchar);
            Console.WriteLine(sastchar);
            Console.ReadLine();

            //onsole.WriteLine(bb.UpperCase("food"));
            Console.WriteLine();
           //owest();
        }

public static int ch(bool istrue)
        {
            int position;
            switch (istrue)
            {
                case false:
                    position = 5;
                    
                    break;

                case true:
                    position = 1;//ay";
                    break;

                
                default:
                    position = 0;
                    //Console.WriteLine(name + "does not belong to this family");
                    break;
                
            }

            return position;
        }







        static void Lowest()
        {
            var bole= new Program();
           //ole.TestOne();
           //ole.TestOne();
            Console.WriteLine("original value of taju=" + bole.taju);
            bole.taju = "gifts wife";
            Console.WriteLine(bole.tau);
            bole.tau = "rice";
            Console.WriteLine(bole.tau);
            Console.WriteLine(bole.tu);
            Console.WriteLine(bole.taju);

           

            var bose = new Program();
            //se.
           //ose.TestOne();
           //ose.TestOne();
            bose.taju = "shope's wife";
            Console.WriteLine(bose.taju);

            Console.WriteLine(Program.test);
            Program.test="new value for test";
            Console.WriteLine(Program.test);

            Console.ReadLine();
          var growth=Program.val;
          //Program.val = "hjdfgdgdsg";
            
        }

        public string UpperCase(string dare)
        {
            var dapo = dare.ToUpper();
            Console.WriteLine(dapo);
            return dapo;
        }








        //     Console.WriteLine(GetGrade (80,100,50));

        //  static double GetGrade(double sScore, double maxScore, double sgrade)
        /*  {

              double result;
              result = sgrade;
              if (sScore /maxScore *100>=50 && sScore /maxScore *100 <=100)
              {

                  Console.WriteLine("Highest Grade");
              }
              else if (sScore /maxScore * 100 == 50)
              {
                  Console.WriteLine("Average Score ");
              }else 
              {
                  Console.WriteLine("Lowest Grade ");
              }
              return result;

         } */

        static void Subjects()
        {
            
        }
      
        
    }
}
