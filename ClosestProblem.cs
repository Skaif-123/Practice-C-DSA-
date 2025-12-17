using System;


internal class ClosestProblem
{
    internal void closestFinder(int n,int m) {

        for (int i = n-1; i >0 ; i--)
        {
            if (i % m == 0)
            {
                Console.WriteLine(i);
                break;
            }

            else
            {
                Console.WriteLine("No Number  that is divisible ");
            }

        }
    
    
    
    }
}