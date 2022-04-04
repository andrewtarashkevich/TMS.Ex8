using System;

namespace ClassLibrary
{
    public static class IOHelper
    {
        //int SaveInput(int min_value, int max_value, string message);
        //* double SaveInput(double min_value, double max_value, string message);
        // (метод SaveInput должен быть перегружен, и в зависимости от типа переданных min_value и max_value вводить целое или вещественное число)
        //* (double, double) InputPoint(string message);
        //* void Line(int length);
        //* int TextMenu(string[] menu_items);
        //* int[] GenerateIntArray(int size, int min, int max);
        //* double[] GenerateDoubleArray(int size, double min, double max);
        //* int[,] GenerateIntMatrix(int rows, int cols, int min, int max);
        //* double[,] GenerateDoubleMatrix(int rows, int cols, double min, double max);
        public static void PrintArray(int[] mas)
        {
            Console.WriteLine(string.Join(" ",mas));
        }
        public static void PrintArray(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintArray(double[] mas)
        {
            Console.WriteLine(string.Join(" ", mas));
        }
        public static void PrintArray(double[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
