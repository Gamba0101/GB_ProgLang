
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("EXERCISE 47");

double[,] Create2DArray () {
    int rows = new Random().Next(3,11);
    int collumns = new Random().Next(3,11);
    Console.WriteLine($"m = {rows}, n = {collumns}.");

    double[,] new2DArray = new double [rows, collumns];

    for (int i = 0; i < rows; i++) {
        for(int j = 0; j < collumns; j++) {
            new2DArray[i,j] = new Random().Next(-10, 11) + new Random().NextDouble();
            new2DArray[i,j] = Math.Round(new2DArray[i,j], 2);
        }
    }
    return new2DArray;
}

void Print2DArray (double[,] ar2D) {
    for (int i = 0; i < ar2D.GetLength(0); i++) {
        for(int j = 0; j < ar2D.GetLength(1); j++) {
            Console.Write(ar2D[i,j] + "  ") ;
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
}

double[,] array1 = Create2DArray();
Print2DArray(array1);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 50");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 52");