using System;

class ObsoleteAttrEx
{
    [Obsolete("경고, Obsolete Method입니다.")]
    public static void OldMethod()
    {
        Console.WriteLine("In the Old Method ...");
    }
    public static void NormalMethod()
    {
        Console.WriteLine("In the Normal Method ...");
    }
    public static void Main()
    {
        ObsoleteAttrEx.OldMethod();
        ObsoleteAttrEx.NormalMethod();
    }
}
