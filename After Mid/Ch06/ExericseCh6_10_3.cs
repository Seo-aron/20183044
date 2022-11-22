using System;

class FinallyClause
{
    public void MethodA()
    {
        try
        {
            Console.WriteLine("1");
        } catch (Exception e)
        {
            Console.WriteLine("2"); // try문이 정상적으로 작동해 catch문 스킵
        }
    }
    public void MethodB()
    {
        try
        {
            Console.WriteLine("3");
        }
        finally
        {
            Console.WriteLine("4"); // finally문은 무조건 작동
        }
    }
}
class ExericseCh6_10_3
{
    public static void Main()
    {
        FinallyClause fc = new FinallyClause();
        fc.MethodA();
        fc.MethodB();
    }
}
