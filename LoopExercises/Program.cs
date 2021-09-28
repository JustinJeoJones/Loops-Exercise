using System;

namespace LoopExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            for(int i = 0; i<=100; i++)
            {
                if(i % 2 == 0) //is even
                {
                    Console.WriteLine(i);
                }
            }
            //2
            bool runProgram = true;
            while(runProgram)
            {
                Console.WriteLine("Do you want to continue looping? y/n");
                string choice = Console.ReadLine();
                if(choice == "n")
                {
                    runProgram = false;
                }
            }
            //3
            int sum = 0;
            for(int i = 0;i<=5; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
