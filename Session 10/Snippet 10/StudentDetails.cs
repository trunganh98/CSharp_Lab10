using Snippet_10;
using System;

namespace Snippet_10
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
            StudentDetails objStudent = new StudentDetails();
            ScoreReport objReport = new ScoreReport();
            Console.WriteLine("Subject: " + objReport.Subject);
            Console.WriteLine("Marks: " + objReport.Marks);
        }
    }
}
