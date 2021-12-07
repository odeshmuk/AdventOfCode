using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the file input.txt
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");
            Part1(lines);
            Console.Write(Part2(lines));
        }

        static int Part1(string[] input)
        {



            if (input.Length > 0)
            {


                int measurementsLargerThanPreviousCount = 0;
                int previousMeasurement = Int32.Parse(input[0]);
                for (int i = 1; i < input.Length; i++)
                {
                    int currentMeasurement = Int32.Parse(input[i]);
                    if (currentMeasurement > previousMeasurement)
                    {
                        measurementsLargerThanPreviousCount++;
                    }
                    previousMeasurement = currentMeasurement;
                }

                return measurementsLargerThanPreviousCount;
            }
            return -1;
        }

        static int Part2(string[] input)
        {
            if (input.Length > 0)
            {
                int measurementsLargerThanPreviousCount = 0;
                int previousMeasurement = Int32.Parse(input[0]) + Int32.Parse(input[1]) + Int32.Parse(input[2]);
                for (int i = 1; i < input.Length-2; i++)
                {
                    int currentMeasurement = Int32.Parse(input[i]) + Int32.Parse(input[i + 1]) + Int32.Parse(input[i + 2]);
                    if (currentMeasurement > previousMeasurement)
                    {
                        measurementsLargerThanPreviousCount++;
                    }
                    previousMeasurement = currentMeasurement;

                }
                return measurementsLargerThanPreviousCount;

            }
            return -1;
        }
    }
}
