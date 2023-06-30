// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("EXERCISE 34");

int size = new Random().Next(3,11);

int[] CreateArray (int size){
    int[] temp_ar = new int[size];
    for (int i = 0; i < size; i++) {
        temp_ar[i] = new Random().Next(100,1000);
    }
    return temp_ar;
}

void PrintArray (int[] print_ar) {
    Console.Write("Your array is: ");
    for (int i = 0; i < print_ar.Length; i++) {
        Console.Write(print_ar[i] + " ");
    }
}

int CountEven (int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
        count += 1;
        }
    }
    return count;
}

int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine(" ");
Console.WriteLine($"Your array has {CountEven(array)} even numbers.");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 36");

int size2 = new Random().Next(3,11);

int[] CreateArray2 (int size){
    int[] temp_ar = new int[size];
    for (int i = 0; i < size; i++) {
        temp_ar[i] = new Random().Next(-99,100);
    }
    return temp_ar;
}

int CountOddS (int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (i % 2 != 0) {
        count = count + array[i];
        }
    }
    return count;
}

int[] array2 = CreateArray2(size2);
PrintArray(array2);
Console.WriteLine(" ");
Console.WriteLine($"The sum of numbers on odd spots is {CountOddS(array2)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Console.WriteLine(" ");
Console.WriteLine("EXERCISE 38");

int size3 = new Random().Next(3,11);

double[] CreateArray3 (int size){
    double[] temp_ar = new double[size];
    for (int i = 0; i < size; i++) {
        temp_ar[i] = new Random().NextDouble();
        temp_ar[i] = Math.Round(temp_ar[i], 2);        
    }
    return temp_ar;
}

void PrintDoubleArray (double[] print_ar) {
    Console.Write("Your array is: ");
    for (int i = 0; i < print_ar.Length; i++) {
        Console.Write(print_ar[i] + " ");
    }
}

double FindMax(double[] temp_array) {
    double max = 0;
    int i = 0;
    while (i <= size3 - 1) {
        if (max <= temp_array[i]) {
            max = temp_array[i];
            i++;
        } else  i++;
    }
    return max;
}

double FindMin(double[] temp_array) {
    int i = 0;
    double min = FindMax(temp_array); 
    while (i <= size3 - 1) {
            if (min >= temp_array[i]) {
                min = temp_array[i];
                i++;
            } else  i++;
        }
    return min;
}

double Difference(double arg1, double arg2) {
    double dif = 0;
    if (arg1 > arg2) dif = arg1 - arg2;
    else  dif = arg2 - arg1;
    // else { 
    //     dif = 0;
    //     Console.WriteLine("Your max and min values are the same.");
    // }
    dif = Math.Round(dif, 2);
    return dif;
}

double[] array3 = CreateArray3(size3);
PrintDoubleArray(array3);
Console.WriteLine("");
Console.WriteLine($"The max number in your array is: {FindMax(array3)}");
Console.WriteLine($"The min number in your array is: {FindMin(array3)}");
Console.WriteLine($"The difference between them is: {Difference(FindMax(array3), FindMin(array3))}");
