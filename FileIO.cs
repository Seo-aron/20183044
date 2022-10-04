using System;
using System.IO;

namespace test01
{
    class FileIO
    {
        static void Main(String[] args)
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0; //스트림의 위치를 시작으로 설정
            for (int i = 0; i <= 20; i++) // 21회읽음
            {
                Console.Write(F.ReadByte() + " ");
            }

            F.Close();
            Console.ReadKey();
        }
    }
    
}