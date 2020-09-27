using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    class EGradeBook
    {
        public string studentName;
        public string subjects;
        public double scores;
        public string grades;
        public double total;
        public double totalScore;


        public EGradeBook(string aStudentName, string aSubject, double aScores, string aGrade,double aTotal,double aTotalScore)
        {
            studentName = aStudentName;
            subjects = aSubject;
            scores = aScores;
            grades = aGrade;
            total = aTotal;
            totalScore = aTotalScore; ;
            
        }
       
        public void   aSubject( )
        {
            subjects = "English";
            subjects = "Mathematics";
            subjects = "Physics";
            subjects = "Chemistry";
            subjects = "Biology";
        }

        //static double score(double num1 = 60.0, double  num2=75.0, double  num3=50.0, double  num4=80.0, double  num5=40.0)
        //{

           
        //}


    }
}
