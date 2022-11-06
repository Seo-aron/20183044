using System;

class GSwap<T> // int, double 클래스를 제네릭을 사용해 하나로 압축
{
    public T x, y; 
    public void swap()
    {
        T temp;
        temp = x; x = y; y = temp; // x = 1, y = 2 -> (temp = 1,) x = 2, y = 1
    }
}
public class Exericse6_11
{
    public static void Main(String[] args)
    {
        GSwap<Int32> i = new GSwap<int>();
        i.x = 1; i.y = 2;
        Console.WriteLine("x : {0}, y : {1}", i.x, i.y); // Swap 하기 전 x, y값 출력
        i.swap();
        Console.WriteLine("x : {0}, y : {1}", i.x, i.y); // Swap 후 x, y값 출력
        // Int형 swap문
        GSwap<Double> d = new GSwap<Double>();
        d.x = 1.0; d.y = 2.0;
        Console.WriteLine("x : {0}, y : {1}", d.x, d.y);
        d.swap();
        Console.WriteLine("x : {0}, y : {1}", d.x, d.y);
        // Double형 swap문
    }
}

