// Задача 47. Задайте двумерный массив размером m×n, 
//            заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());
WriteLine("введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());
double[,] numbers = new double[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
 	 
void FillArrayRandomNumbers(double[,] array)
{
 	for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
             array[i, j] = Convert.ToDouble(new Random().Next(-10000, 10000)) / 1000;
            }
        }
}
 	 
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
            Write(array[i, j] + " ");
            }
            Write("]");
            WriteLine("");
        }
}