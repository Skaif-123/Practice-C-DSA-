using System;

internal class Sum_Of_Squares_Of_Natural_Numbers
{
    int sum = 0;
    internal void sum_func1(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            sum = sum + (i * i);

        }
        Console.Write(sum);
    }
}