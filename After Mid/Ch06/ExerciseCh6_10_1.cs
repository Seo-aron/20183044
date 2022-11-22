using System;
using System.Collections.Generic;

namespace Chapter6
{
    class GClass<T>
    {
        private List<T> list;
        public GClass()
        {
            list = new List<T>();
        }
        public String getValue()
        {
            String str = "";
            foreach (T e in list) 
                str += (e.ToString() + " "); // str에 String e의 10 20 30 넣는다
            return str;
        }
        public void setValue(params T[] args)
        {
            foreach (T e in args) 
                list.Add(e); // int e에 args배열을 넣고 10 20 30을 넣는다
        }
    }
    public class ExerciseCh6_10_1
    {
        static void Main(string[] args)
        {
            GClass<int> gInteger = new GClass<int>(); // int타입 객체 생성
            gInteger.setValue(10, 20, 30);
            Console.WriteLine(gInteger.getValue());
        }
    }
} 
