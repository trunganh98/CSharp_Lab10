using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_11
{
    class StudentDetails
    {
        string studName = "Alexander";
        int studID = 30;
        public StudentDetails()
        {
            Console.WriteLine("Student Name: " + studName);
            Console.WriteLine("Student ID: " + studID);
        }
    }
}
namespace Examination
{
    class ScoreReport
    {
        public string Subject = "Science";
        public int Marks = 60;
        static void Main(string[] args)
        {
            Snippet_11.StudentDetails objStudent = new Snippet_11.StudentDetails();
            ScoreReport objReport = new ScoreReport();
            Console.WriteLine("Subject: " + objReport.Subject);
            Console.WriteLine("Mark: " + objReport.Marks);
        }
    }
}
