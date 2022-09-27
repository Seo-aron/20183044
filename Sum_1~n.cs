using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20183044
{
    internal class Sum_1_n
    {

        public static void Main()
        {
            int n, s, i;
            Console.Write("Enter a number = ");
            for (; ; )
            {
                n = Console.Read() - '0';
                if (n == 0) break; // 0 입력 시 종료
                else if (n < 0) continue; // 음의 수는 무시
                for (s = 0, i = 1; i <= n; ++i)
                    s += i;
                Console.WriteLine("n = " + n + ", sum = " + s);
            }
            Console.WriteLine("End of Main");

        }
    }
}

