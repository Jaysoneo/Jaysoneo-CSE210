using System;
using System.Collections.Generic;

namespace solo4
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            float number = -1;
            float sum = 0;
            int counter = 0;
            float max = -10000;
            float min = 10000;
            List<float> numbers = new List<float>();
            
            Console.WriteLine("type 0 to stop");
            while(number != 0)
            {
                Console.WriteLine("Introduce a number");
                string STRnumber = Console.ReadLine();
                number = float.Parse(STRnumber);
                numbers.Add(number);
                sum = sum + number;
                if(number>max)
                {
                    max = number;
                }
                if(number>0 & min>number)
                {
                    min = number;
                }
                counter++;
            }
            float average = sum/counter;
            numbers.Sort();
            Console.WriteLine($"The total is {sum}, the average is {average}, min is {min} and the max is {max}");
            foreach (float digit in numbers)
            {
                Console.WriteLine(digit);
            }
        }
    }
}