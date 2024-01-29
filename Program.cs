using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[3, 3];

      
        Console.WriteLine("Please enter the array numbers:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("number [{0}, {1}]: ", i, j);
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

       
        int largest = array[0, 0];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (array[i, j] > largest)
                {
                    largest = array[i, j];
                }
            }
        }

      
        Console.WriteLine("The largest number in the array: " + largest);
    }
}