using System;
public class MultipleValues

{
    private static void fun(ref int x, ref int y)
    {
        x = 1;
        y = 2;
    }
    public static void Main()
    {
        int x = 0;
        int y = 0;
        fun(ref x, ref y);
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }
}