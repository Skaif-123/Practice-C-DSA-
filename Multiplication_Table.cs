using System;


internal class MultiplicationTable
{
    internal void  Multiplication_Table(int num)
    {
        Console.WriteLine("Multiplication Table (1 to 10):");
        for (int i=1;i<11;i++) {
            Console.WriteLine(num+" * "+i+"="+(num * i));
        }
       
    }
}