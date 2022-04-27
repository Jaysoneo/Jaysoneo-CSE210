using System;

namespace solo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your grade?");
            string writtengrade = Console.ReadLine();

            float grade = float.Parse(writtengrade);

            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}