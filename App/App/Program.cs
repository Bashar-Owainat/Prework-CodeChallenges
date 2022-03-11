using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 4, 2, 2, 2, 7, 3 };
            Console.WriteLine(arrayMaxResult(arr));


        }

        static int arrayMaxResult(int[] arr )
        {
            printArray(arr);
            int repititions = 0;
            Console.WriteLine("Please pick a number from the list");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == userInput)
                {
                repititions += 1;

                }

            }
 
            int result = userInput * repititions;
            return result;
        }
        static void printArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }


    }

}
