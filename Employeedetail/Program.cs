using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            Random random = new Random();
            string name = Console.ReadLine();
            int empCheck = random.Next(0, 2);
            if (empCheck == FULL_TIME)
            {
                Console.WriteLine(name + " is Present");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(name + " is Absent");
                Console.ReadLine();
            }
        }
    }
}
