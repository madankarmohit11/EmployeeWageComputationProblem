using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            int Empratewageperhour = 20;
            int Empwage = 0;
            int Emphour = 0;
            Random random = new Random();
            string name = Console.ReadLine();
            int empCheck = random.Next(0, 2);
            if (empCheck == FULL_TIME)
            {
                Emphour = 8;
                Console.WriteLine(name + " is Present and working hour is" + Emphour);
            }
            else
            {
                Emphour = 0;
                Console.WriteLine(name + " is Absent and working hour is" + Emphour);
                
            }
           
            Empwage = Empratewageperhour * Emphour;
            Console.WriteLine("Employee wage is" + Empwage);
            Console.ReadLine();
        }
    }
}
