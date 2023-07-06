
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("EXERCISE 47");

double[,] CreateDouble2DArray () {
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

void PrintDouble2DArray (double[,] ar2D) {
    for (int i = 0; i < ar2D.GetLength(0); i++) {
        for(int j = 0; j < ar2D.GetLength(1); j++) {
            Console.Write(ar2D[i,j] + "  ") ;
        }
        Console.WriteLine(); 
    }
}

double[,] array1 = CreateDouble2DArray();
PrintDouble2DArray(array1);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 50");

int[,] CreateInt2DArray () {
    int rows = new Random().Next(3,8);
    int collumns = new Random().Next(3,8);
    Console.WriteLine($"m = {rows}, n = {collumns}.");

    int[,] new2DArray = new int [rows, collumns];

    for (int i = 0; i < rows; i++) {
        for(int j = 0; j < collumns; j++) {
            new2DArray[i,j] = new Random().Next(1, 21);
        }
    }
    return new2DArray;
}

void PrintInt2DArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i,j] + "  ") ;
        }
        Console.WriteLine(); 
    }
}

void FindAmount (int[,] array, int arg1, int arg2) {
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            if (i == arg1 && j == arg2)    temp = array[i,j];
        }
    }
    if (temp != 0)    Console.WriteLine($"({arg1},{arg2}) - {temp}");
    else  Console.WriteLine($"({arg1},{arg2}) - такого числа в массиве нет");
}

Console.WriteLine("Enter index of rows: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter index of collums: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array2 = CreateInt2DArray();
PrintInt2DArray(array2);
FindAmount(array2, x, y);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 52");

