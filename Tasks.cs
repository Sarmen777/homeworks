
using System;
class Program
{
    unsafe public static void Main()
    {
        int* ptr = stackalloc int[10];
        
        Console.WriteLine("Input 10 elements");

        for (int i = 0; i < 10; i++)
        {
            *(ptr + i) = Convert.ToInt32(Console.ReadLine());
        }

        int maxIndex = 0;
        int maxValue = *ptr;

        for (int i = 1; i < 10; i++)
        {
            if (*(ptr + i) > maxValue)
            {
                maxValue = *(ptr + i);
                maxIndex = i;
            }
        }

    }
}


