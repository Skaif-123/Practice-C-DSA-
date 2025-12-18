using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


public  class Sum_of_Digits
{
        int sum = 0;
 

   

    internal int addedDigit(int num)
    {
    while(num>0)
        {
           int n = num % 10;
            num = (int) num / 10;
            sum = sum + n;
        }

        return sum;

    }


}