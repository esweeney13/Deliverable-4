/*
 Author: Erik Sweeney
 Date: 2/10/23

 
*/

using System;

namespace Arrays
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] fibSeq = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368};

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Fibonacci Number (" + i + ") = " + fibSeq[i]);
            }
        }
    }
}


