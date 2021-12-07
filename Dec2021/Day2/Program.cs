using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input.txt
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");
            //Console.WriteLine(Part1(lines));
            Console.WriteLine(Part2(lines));
        }

        static long Part1(string[] lines)

        {
           long XDirection = 0;
            long YDirection = 0;
            foreach (string line in lines)
            {
                //Split string into array of strings
                string[] split = line.Split(' ');
                string direction = split[0];
                int value = Int32.Parse(split[1]);
                if (direction == "down")
                {
                    
                    YDirection += value;
                }
                else if (direction == "up")
                {
                   
                    YDirection -= value;
                }
                else if (direction == "forward")
                {
                    
                    XDirection += value;
                }
            }
            return (XDirection*YDirection);
        }
    

        static double Part2(string[] lines){
            double XDirection = 0;
            double YDirection = 0;
            double aim =0;
            foreach (string line in lines)
            {
                //Split string into array of strings
                string[] split = line.Split(' ');
                string direction = split[0];
                int value = Int32.Parse(split[1]);
                if (direction == "down")
                {
                    
                    aim += value;
                }
                else if (direction == "up")
                {
                    aim -= value;
                }
                else if (direction == "forward")
                {
                    
                     XDirection+= value;
                     YDirection+= aim*value;
                }
                Console.Write(line+" Aim "+aim);
                Console.Write(" XDirection "+XDirection);
                Console.WriteLine(" YDirection "+YDirection);
            }
            return (XDirection*YDirection);

        }
    }

}
