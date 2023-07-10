// Задача 1. Задайте двумерный массив. Напишите программу которая поменяет местами две любые строчки массива.

int [,] Create2dArray (int row, int collumn, int min, int max) {
    int[,] createdArray = new int[row,collumn];
    for (int i =0; i < row; i++) 
        for (int j = 0; j < collumn; j++) 
        createdArray[i,j] = new Random().Next(min, max + 1);
    return createdArray;
}

void ShowArray (int[,] printedArray) {
    for (int i = 0; i < printedArray.GetLength(0); i++) {
        for (int j = 0; j < printedArray.GetLength(1); j++)    Console.Write(printedArray[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeRows (int[,] arrayToChange, int row1, int row2) {
    if (row1 >= 0 && row1 < arrayToChange.GetLength(0) &&
    row1 != row2 && 
    row2 >= 0 && row2 < arrayToChange.GetLength(0)) {
        for (int j = 0; j < arrayToChange.GetLength(1); j++) {
            int temp = arrayToChange[row1, j];
            arrayToChange[row1, j] = arrayToChange[row2, j];
            arrayToChange[row2, j] = temp;
        }
    } else Console.WriteLine("Error: Impossible value.");
    return arrayToChange;
}

Console.WriteLine("Input count of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of collumns: ");
int user_cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int user_max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(user_rows, user_cols, user_min, user_max);
ShowArray(newArray);

Console.Write($"Input number of first row to swap from 0 to {user_rows-1}: ");
int user_first_row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input number of second row to swap from 0 to {user_rows-1}: ");
int user_second_row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your changed array: ");
ShowArray(ChangeRows(newArray, user_first_row, user_second_row));