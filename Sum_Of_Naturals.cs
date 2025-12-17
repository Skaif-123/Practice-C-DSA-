using System;

internal class Sum_Of_Naturals
{

    internal void Sum_Of_Naturals_Number(int num)
    {


        int sum = 0;
        for (int i = 0; i <= num; i++)
        {
            sum = sum + i;
        }
        Console.Write("The Sum of Number is " + sum);

    }


}