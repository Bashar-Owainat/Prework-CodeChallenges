using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 4, 2, 2, 2, 7, 3 };
            int[] arr2 = { 0, 2, -2 };
            int[,] arr3 = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.WriteLine("Result for arrayMaxResult : " + arrayMaxResult(arr));
            Console.WriteLine("Result for LeapYearCalculator : " + LeapYearCalculator(2000));
            Console.WriteLine("Result for perfectSequence: " + perfectSequence(arr2));
            Console.WriteLine("Result for SumOfRows : "  );
            int[] resultArr = SumOfRows(arr3, 3, 5);
            printArray(resultArr);

        }



        static int arrayMaxResult(int[] arr)
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




        static Boolean LeapYearCalculator(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }




        static String perfectSequence(int[] arr)
        {
            Boolean flag = true;
            int sum = 0;
            int product = 1;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < 0)
                {
                    flag = false;

                }
                else
                {
                    sum = sum + arr[i];
                    product = product * arr[i];
                }
            }

            if (flag == true && sum == product)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }



        static int[] SumOfRows(int[,] arr, int rows, int cols)
        {
            int[] sum = new int[rows];
            
         
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum[i] += arr[i, j];
                }
            }
            return sum;
        }


    }
}
