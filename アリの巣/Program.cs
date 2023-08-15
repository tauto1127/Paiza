using System;

namespace アリの巣
{
    class Program
    {
        static int[,] cage;
        static int H, W, y, x;
        static int[] aunt = new int[2];
        static void Main(string[] args)
        {
            
            var line = Console.ReadLine().Split(' ');
            H = Int16.Parse(line[0]);
            W = Int16.Parse(line[1]);
            y = Int16.Parse(line[2]);
            x = Int16.Parse(line[3]);

            cage = new int[H, W];
            
            for (int i = 0; i < H; i++)
            {
                line = Console.ReadLine().Split(' ');
                for (int j = 0; j < W; j++)
                {
                    cage[i, j] = Int16.Parse(line[j]);
                }
            }

            bool isProcessing = true;
            
            while (isProcessing)
            {
                
            }
        }

        void nextCage()
        {
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    cage[i, j]--;
                }
            }
        }

        private bool checkCanForward(int x, int y, string direction)
        {
            if (direction == "UP" && y + 1 >= 0)
            {
                if (cage[x, y + 1] > 0)
                {
                    return true;
                }
            }

            if (direction == "DOWN" && y - 1 >= 0)
            {
                if (cage[x, y - 1] > 0)
                {
                    return true;
                }
            }

            if (direction == "RIGHT" && x + 1 >= 0)
            {
                if (cage[x + 1, y] > 0)
                {
                    return true;
                }
            }

            if (direction == "LEFT" && x - 1 >= 0)
            {
                if (cage[x -1 , y] > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}