using System;


class Program
{
    static void Main()
    {
        Odd_Even_finder obj = new Odd_Even_finder();
        Console.WriteLine("Enter your Nuumber ");
        Int32 num=Convert.ToInt32( Console.ReadLine());

        obj.Odd_Even_finding_method(num);

    }
}