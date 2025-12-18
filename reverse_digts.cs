using System;


internal class Reverse_Digits
{
    internal int reveresedNumber(int num)
    {
        int sum = 0;

        while (num>0)
        {
            int n = num % 10;
            num = num / 10;
            sum = sum * 10 + n;

        }

        return sum;
    }
}