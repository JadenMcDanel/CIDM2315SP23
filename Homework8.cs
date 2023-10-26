namespace Homework8;

using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] int_array = { 11, 23, 31, 42, 53 };
        int sum = ArraySum(int_array);
        Console.WriteLine("Sum of int_array is: " + sum);
        int[,] array_2d = {{1, 2, 3, 4, 5, 6, 7, 8, 9}};
        PrintAllOddNumber(array_2d);
        int sum2d = ElementSum(array_2d);
        Console.WriteLine("Sum of 2D array: " + sum2d);
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2D array:");
        for (int i = 0; i < Q2_3.GetLength(0); i++)
        {
            for (int j = 0; j < Q2_3.GetLength(1); j++)
            {
                Console.Write(Q2_3[i, j] + " ");
            }
            Console.WriteLine();
        } }
    public static int ArraySum(int[] int_array)
    {
        int sum = 0;
        foreach (int num in int_array)
        {
            sum += num;
        }
        return sum;
    }
    public static void PrintAllOddNumber(int[,] array_2d)
{
    string oddNumbers = "" ;
    for (int i = 0; i < array_2d.GetLength(0); i++)
    {
        for (int j = 0; j < array_2d.GetLength(1); j++)
        {
            if (array_2d[i, j] % 2 != 0)
            {
                oddNumbers += array_2d[i, j] + " ";
            }
        }
    }
    Console.WriteLine(oddNumbers);
} public static int ElementSum(int[,] array_2d)
    {
        int sum = 0;
        for (int i = 0; i < array_2d.GetLength(0); i++)
        {
            for (int j = 0; j < array_2d.GetLength(1); j++)
            {
                sum += array_2d[i, j];
            }
        }
        return sum;
    }
        public static int[,] DoubleArray(int[,] array_2d)
    {
        int[,] doubledArray = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
        for (int i = 0; i < array_2d.GetLength(0); i++)
        {
            for (int j = 0; j < array_2d.GetLength(1); j++)
            {
                doubledArray[i, j] = array_2d[i, j] * 2;
            }
        }
        return doubledArray;
    }
}
