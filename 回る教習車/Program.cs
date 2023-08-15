using System;

namespace 回る教習車
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Trim();
            var N = int.Parse(line1);
            string[] splittedLine;
            for (var i = 0; i < N; i++)
            {
                splittedLine = Console.ReadLine().Trim().Split(' ');
                Console.WriteLine("hello = {0} , world = {1}", splittedLine[0], splittedLine[1]);
            }
            int carCount = Int16.Parse(splittedLine[0]);
            int[,] car = new int[carCount,2];
            for (int i = 1; i < carCount; i++)
            {
                car[i,0] = SplittedLine[i];
                car[i, 1] = 0;
            }

            int count = 1;
            bool isProcessing = true;
            while (isProcessing)
            {
                for (int i = 0; i < carCount; i++)
                {
                    car[i, 1] ++;
                    if (count == car[i, 0])
                    {
                        count++;
                        if (count == carCount)
                        {
                            Console.WriteLine(car[i, 1]);
                            isProcessing = false;
                            break;
                        }
                    }
                }
                
            }
        }
    }
}