using System;
namespace University{
    class Student
    {
        public string Major;
        public int Credits;
        public string FirstName;
        public string LastName;
        
        //costructor
        public Student()
        { 
            Major = major;
            Credits = credits;
            FirstName = firstName;
            LastName = lastName;
        }
        
        
        public void DisplayName()
        {
            Console.WriteLine($"The student's name is {FirstName} {LastName}");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"");
        }
    }
}