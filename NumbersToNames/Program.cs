using System;

namespace NumbersToNames
{
    class Program
    {
        enum Months 
        { 
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Project: Numbers to Names");
            Console.WriteLine("Hello, if you give me a number, I will tell you which month it corresponds to! Please enter a number ");
            int monthNum = Int32.Parse(Console.ReadLine());
            while (monthNum <= 0 || monthNum > 12) 
            {
                Console.WriteLine("Please enter a valid number for a month it will correspond to:");
                monthNum = Int32.Parse(Console.ReadLine());
            }


            int count = 1;
            foreach (Months m in Enum.GetValues(typeof(Months))) 
            {
                if (monthNum == count)
                {
                    Console.Write("The name of the month is " + (m));
                    return;
                }
                else 
                {
                    count++;
                }
            }

        }
    }
}
