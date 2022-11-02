using System;
namespace DateTime_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("오늘은 {0}년 {1}월 {2}일 ({3})이며",
            dt.Year, dt.Month, dt.Day, dt.DayOfWeek);
            Console.WriteLine("현재는 {0}시 {1}분 {2}초 입니다.",
            dt.Hour, dt.Minute, dt.Day, dt.Second);
        }
    }
}
