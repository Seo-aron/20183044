using System;
public class StaticVsInstanceApp
{
    int instanceVariable; // private : default
    static int staticVariable;
    public static void Main()
    {
        StaticVsInstanceApp obj = new StaticVsInstanceApp();
        obj.instanceVariable = 10; // 객체
        //StaticVsInstanceApp.instanceVariable = 10; // error

        StaticVsInstanceApp.staticVariable = 20; // 클래스                                       
        //obj.staticVariable = 20; // error

        Console.WriteLine("instance variable={0}, static variable={1}",
        obj.instanceVariable, StaticVsInstanceApp.staticVariable);
    }
}
