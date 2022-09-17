//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("hello");
//        }
//    }
//}

//hello 출력

//using System;
//class IdentifierApp
//{
//    public static void Main()
//    {
//        int MyVar = 1, myvar = 2;
//        int @int = 10, 변수 = 20;
//        Console.WriteLine("MyVar = " + MyVar + ", myvar = " + myvar);
//        Console.WriteLine("@int = " + @int + ", 변수 = " + 변수);
//    }
//}

//변수선언 및 출력

//using System;
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int value = Console.Read();
//            Console.WriteLine("Read Result : {0}", value);
//        }
//    }
//}

//아스키코드값 출력

//using System;
//class ReadLineApp
//{
//    public static void Main()
//    {
//        int time, hour, minute, second;
//        Console.WriteLine("***Enter an integral time: ");
//        time = int.Parse(Console.ReadLine());
//        hour = time / 10000;
//        minute = time / 100 % 100;
//        second = time % 100;
//        Console.WriteLine("***Time is " + hour + ":" + minute + ":" + second);
//    }
//}

//nnnnnn입력시 nn:nn:nn으로 출력

//using System;
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                ConsoleKeyInfo name = Console.ReadKey();
//                Console.WriteLine("\n You Press : {0}", name.Key);
//            }
//        }
//    }
//}

//무슨 키를 눌렀는지 출력

//using System;
//class ReadIntegerApp
//{
//    static int ReadInt()
//    {
//        char ch;
//        int n = 0;
//        while (!char.IsDigit(ch = (char)Console.Read())) ;
//        do
//        {
//            n = n * 10 + (ch - '0');
//            ch = (char)Console.Read();
//        } while (char.IsDigit(ch)); // 숫자가 아닌 글자 입력 시 벗어남
//        return n;
//    }
//    public static void Main()
//    {
//        Console.Write("*** input data : ");
//        Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt());
//    }
//}

//숫자만 출력

//using System;
//namespace standard_output_2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a = 3;
//            double b = 4;
//            Console.WriteLine("Pythagorean Theory of {0} and {1}:", a, b);
//            Console.WriteLine("Geometric ={0,12:F3}", Math.Sqrt(a * a + b * b));
//            Console.WriteLine("Geometric ={0:F3}", Math.Sqrt(a * a + b * b));
//            double k = 3.4567;
//            Console.WriteLine("Percent Value = {0, 10:P3}", k);
//            Console.WriteLine("Percent Value = {0:P3}", k);
//            int value = 34561234;
//            Console.WriteLine("decimal Value = {0, -15:D}", value);
//            Console.WriteLine("decimal Value = {0:D10}", value);
//        }
//    }
//}

//피타고라스