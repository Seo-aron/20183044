using System;
using System.IO;

namespace test01
{
    class File_hello
    {
        static void Main()
        {
            FileStream fs;

            try
            {
                fs = new FileStream("file2.txt", FileMode.Create);
            }
            catch (IOException)
            {
                Console.WriteLine("파일을 열 수 없습니다.");
                return;
            }

            StreamWriter w = new StreamWriter(fs);
            w.Write("안녕하세요. C#");
            w.Close();

            Console.WriteLine("안녕하세요. C#");
        }
    }
}
