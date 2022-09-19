using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arrayOfArray = new int[3][];      // declaration: 선언
            int i, j;
            for (i = 0; i < arrayOfArray.Length; i++) // creation: 생성
                arrayOfArray[i] = new int[i + 3];     // [3],[4],[5] 배열 생성
            for (i = 0; i < arrayOfArray.Length; i++) // 초기화 사용
                for (j = 0; j < arrayOfArray[i].Length; j++)
                    arrayOfArray[i][j] = i * arrayOfArray[i].Length + j; // I * 3 + j, i*4+j, I *5+j
            for (i = 0; i < arrayOfArray.Length; i++) // 내용 출력
            {
                for (j = 0; j < arrayOfArray[i].Length; j++)
                    Console.Write(" " + arrayOfArray[i][j]);
                Console.WriteLine();
            }
        }
    }
}
