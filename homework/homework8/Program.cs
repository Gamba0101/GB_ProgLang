﻿
int [,] Create2DArray (int row, int collumn) {
    int[,] createdArray = new int[row,collumn];
    for (int i =0; i < row; i++) 
        for (int j = 0; j < collumn; j++) 
        createdArray[i,j] = new Random().Next(10, 21);
    return createdArray;
}

void Print2DArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i,j] + "  ") ;
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(" ");
}

/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.WriteLine("EXERCISE 54");

Console.WriteLine("Input count of rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of collumns: ");
int cols1 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = Create2DArray(rows1, cols1);
Print2DArray(array1);

void OrderRows(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)  {
        for (int j = 0; j < array.GetLength(1); j++)  {
            for (int k = 0; k < array.GetLength(1) - 1; k++)  {
                if (array[i, k] < array[i, k + 1])  {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Your ordered array: ");
OrderRows(array1);
Print2DArray(array1);

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 56");

Console.WriteLine("Input count of rows: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input count of collumns that DOESN'T = {rows2}: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

int error = 0;

if (rows2 == cols2) error = 1;

int FindMaxRowSum (int[,] array) {
    int i = 0;
    int temp = 0;
    int max = 0;
    while (i < array.GetLength(0)) { 
        for (int j = 0; j < array.GetLength(1); j++) {
        temp = array[i,j] + temp;
        }
        if (temp > max) max = temp;
        i++;
    }
    return max;
}

void FindMinRowSum (int[,] array, int max) {
    int i = 0;
    int temp = 0;
    int min = max;
    while (i < array.GetLength(0)) { 
        for (int j = 0; j < array.GetLength(1); j++) {
            temp = array[i,j] + temp;
        }
        if (temp < min) min = temp;
        i++;
    }
    Console.Write(min);
}

if (error != 1) {
    Console.WriteLine(" ");
    int[,] array2 = Create2DArray(rows2, cols2);
    Print2DArray(array2);
    Console.WriteLine("Your MIN row sum is: ");
    FindMinRowSum(array2, FindMaxRowSum(array2));
    Console.WriteLine(" ");
} else {
    Console.WriteLine("Error: impossible input.");
}
/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 58");

Console.WriteLine("Input count of rows: ");
int rows3_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of collumns: ");
int cols3_1 = Convert.ToInt32(Console.ReadLine());

int[,] array3_1 = Create2DArray(rows3_1, cols3_1);
Console.WriteLine(" ");
Console.WriteLine("Your array 1 is:");
Print2DArray(array3_1);
Console.WriteLine(" ");

Console.WriteLine("Input count of rows: ");
int rows3_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of collumns: ");
int cols3_2 = Convert.ToInt32(Console.ReadLine());

int[,] array3_2 = Create2DArray(rows3_2, cols3_2);
Console.WriteLine(" ");
Console.WriteLine("Your array 2 is:");
Print2DArray(array3_2);

int[,] ArrayMultiply (int[,] array1, int[,] array2) {
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++) {
        for (int j = 0; j < array2.GetLength(1); j++)  {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++) {
                sum += array1[i,k] * array2[k,j]; }
            result[i,j] = sum;
        }
    }
    return result;
}

if (rows3_1 != cols3_2) Console.WriteLine("Error: impossible input.");
else {
    Console.WriteLine(" ");
    Console.WriteLine("Array 1 multiplied by array 2 = ");
    Print2DArray(ArrayMultiply(array3_1, array3_2));
}

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 60");

Console.WriteLine("Input count of rows: ");
int rows4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of collumns: ");
int cols4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of 3D rows: ");
int vol4 = Convert.ToInt32(Console.ReadLine());

int [,,] Create3DArray (int row, int collumn, int volume) {
    int[,,] createdArray = new int[row,collumn,volume];
    for (int i =0; i < row; i++) 
        for (int j = 0; j < collumn; j++)
            for (int l = 0; l < volume; l++) 
                createdArray[i,j,l] = new Random().Next(10, 100);
    return createdArray;
}

void Print3DArray (int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            for(int l = 0; l < array.GetLength(2); l++) {
                Console.Write($"{array[i,j,l]} ({i},{j},{l}) ");
            }
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(" ");
}

int[,,] array4 = Create3DArray(rows4, cols4, vol4);
Print3DArray(array4);

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 62");

int[,] CreateSpiralArray(int n)  {
        int[,] array = new int[n, n];
        int direction = 0;  // 0: right, 1: down, 2: left, 3: up
        int row = 0, col = 0;
        int num = 1;

        for (int i = 1; i <= n * n; i++) {
            array[row, col] = num;
            num++;
            if (direction == 0) {
                if (col + 1 >= n || array[row, col + 1] != 0) {
                    direction = 1;  // change direction to down
                    row++;
                } else col++;
            } else if (direction == 1) {
                if (row + 1 >= n || array[row + 1, col] != 0) {
                    direction = 2;  // change direction to left
                    col--;
                }  else    row++;
            } else if (direction == 2)  {
                if (col - 1 < 0 || array[row, col - 1] != 0) {
                    direction = 3;  // change direction to up
                    row--;
                } else    col--;
            } else if (direction == 3)  {
                if (row - 1 < 0 || array[row - 1, col] != 0) {
                    direction = 0;  // change direction to right
                    col++;
                } else    row--;
            }
        }
        return array;
    }


int[,] array5 = CreateSpiralArray(4);
Print2DArray(array5);
