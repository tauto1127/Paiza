using System;
using System.Collections;

namespace 映画館の席の予約
{
    class Program
    {
        static void Main(string[] args)
        {
            int ReservedCount, SeatHeightCount, SeatWidthCount, PSeatX, PSeatY;
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var splited = Console.ReadLine().Split(' ');
            ReservedCount = Int16.Parse(splited[0]);
            SeatHeightCount = Int16.Parse(splited[1]);
            SeatWidthCount = Int16.Parse(splited[2]);
            PSeatY = Int16.Parse(splited[3]);
            PSeatX = Int16.Parse(splited[4]);
            bool[,] seat = new bool[SeatHeightCount,SeatWidthCount];
            var splitedXY = new string[2];
            for(int i = 0;i < ReservedCount; i++){
                splitedXY = Console.ReadLine().Split(' ');
                seat[Int16.Parse(splitedXY[0]),Int16.Parse(splitedXY[1])] = true;
            }
            int tikaiDistance = 100;
            int distance;
            var tikaiSeat = new ArrayList();
            for(int i = 0;i < SeatHeightCount; i++){
                for(int j = 0; j < SeatWidthCount; j++){
                    if(seat[i,j] != null){
                        if(seat[i,j] == false){
                            distance = Math.Abs(i - PSeatY) + Math.Abs(j - PSeatX);
                            if(distance < tikaiDistance){
                                tikaiDistance = distance;
                                tikaiSeat = new ArrayList();
                                tikaiSeat.Add(i + " " + j);
                            }else if(distance == tikaiDistance){
                                tikaiSeat.Add(i + " " + j);
                            }
                        }
                    }
                }
            }
            foreach(string str in tikaiSeat){
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}