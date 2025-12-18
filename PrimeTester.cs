using System;


internal class PrimeTester
{
    internal void tester(int num)
    {
        if (num == 2)
        {
            Console.WriteLine("prime number");
        }
        else if (num % 2 == 0)
        {
            Console.WriteLine("Is not prime number");
        }
        else
        {
            for (int i = 3; i < num; i++)
            {
                if (num %i==0) {
                    Console.WriteLine("Nummber is not Prime");
                    break;
                }
            }
            Console.WriteLine("Is prime number");
        }
    }

}