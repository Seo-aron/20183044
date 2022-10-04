using System;
using System.IO;

namespace test01
{
    internal class FileStreamSize
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"C:\Temp\vs.png", FileMode.Open))
            {
                int size = (int)fs.Length;
                byte[] buff = new byte[size];

                for (int i=0; i<10; i++) // 이미지의 크기를 10번 나타냄
                {
                    int n = fs.Read(buff, 0, size / 10);
                    Console.WriteLine(n);
                }
            }
        }
    }
}
