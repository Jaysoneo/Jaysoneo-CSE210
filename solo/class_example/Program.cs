using System;
using University;


namespace Unit02
{
    class Program
    {
        static int Main(string[] args)
        {
            Student student1 = new Student();
            student1.Major = "Biology";
            student1.Credits = 12;
            student1.FirstName ="Bob";
            student1.LastName ="Gates";

            Console.WriteLine($"The student {student1.FirstName} {student1.LastName} has {student1.Credits} credits in {student1.Major}. Congratulations!!!");
        }
    }
}
