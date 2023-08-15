using System;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        /*
         * 4
1 2
2 3
5 7
8 15
         */
        int renzokuNissuu = 0;
        int last = 0;
        int maxRenzokuNissuu = 0;
        int min = 0;
        int max = 0;
        string line = Console.ReadLine();
        int n = int.Parse(line);
        string input = Console.ReadLine();
        var splited = input.Trim().Split(' ');
        min = int.Parse(splited[0]);
        max = int.Parse(splited[1]);
        renzokuNissuu = max - min + 1;//3
        last = int.Parse(splited[1]);//4
        for(int i = 1;i < n;i++){
            input = Console.ReadLine();
            splited = input.Trim().Split(' ');
            int A = int.Parse(splited[0]);
            int B = int.Parse(splited[1]);//5 6
            if(A <= last + 1 && B > last){
                //Console.WriteLine("A:" + A +  "B:" + B);
                max = B;
                renzokuNissuu = max - min + 1;
                last = B;
            }else{
                maxRenzokuNissuu = renzokuNissuu;


                min = A;
                max = B;
                renzokuNissuu = max - min + 1;
                last = B;
                
            }
            //Console.WriteLine(renzokuNissuu);
        }
        if(maxRenzokuNissuu < renzokuNissuu){
            maxRenzokuNissuu = renzokuNissuu;
        }
        Console.WriteLine(maxRenzokuNissuu);
    }
}