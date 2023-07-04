// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("EXERCISE 41");

Console.WriteLine("Please input how many numbers you want inputted: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray (int size){
    int[] temp_ar = new int[size];
    for (int i = 0; i < size; i++) {
        temp_ar[i] = new Random().Next(-1000,1000);
    }
    return temp_ar;
}

void PrintArray (int[] print_ar) {
    Console.Write("Your array is: ");
    for (int i = 0; i < print_ar.Length; i++) {
        Console.Write(print_ar[i] + " ");
    }
}

int MoreThanZero (int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) {
        count += 1;
        }
    }
    return count;
}

int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine(" ");
Console.WriteLine($"Your array has {MoreThanZero(array)} numbers bigger than 0.");

// Solving using Split and Parse C# functions
/*
Console.Write("Put in your numbers (seperate them with a space): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)    count++;
}

Console.WriteLine($"{count} numbers you inputted are > 0");
 */



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 43");

Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

double a = k2 - k1;
double b = b1 - b2;

if (a == 0 && b == 0) Console.WriteLine("Your lines are the same.");
else if (a == 0)    Console.WriteLine("The two lines are parallel.");
else {
    double x = - b/a;
    double y = k1 * x + b1;
    Console.WriteLine($"Your lines cross at ({x}; {y})");
}
 
// если a1b2 - a2b1 = 0 - параллельны,
// если a1b2 - a2b1 = 0 и c2b1-c1b2 = 0 - совпадают 