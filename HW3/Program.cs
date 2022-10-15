using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, -1, 0, 2, 3, -4, 5, 4, -8, 7, 11 };
        Array.Sort(a);
        foreach (int i in a)
            if(i != 0)
            Console.WriteLine(i);
    
    }
}