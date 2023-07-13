// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задача 64");
Console.WriteLine(" ");

void ShowNumbers (int n) {
    Console.Write($"{n} ");
    if (n > 1) ShowNumbers (n-1);
}

Console.WriteLine("Enter your num: ");
int num1 = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num1);
Console.WriteLine(" ");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine(" ");
Console.WriteLine("Задача 66");

int CountRange(int a, int b) {
    if (a == b) {
        return 1; 
    } else if (a > b) {
        return b + CountRange(a, b + 1); 
    } else {
        return a + CountRange(a + 1, b);
    }
}

Console.WriteLine("Enter your first num: ");
int num2_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second num: ");
int num2_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine($"The sum of all the numbers between {num2_1} and {num2_2} is {CountRange(num2_1, num2_2)}");

// Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine(" ");
Console.WriteLine("Задача 68");

int Ackermann(int m, int n) {
    if (m == 0)   return n + 1;
    else if (n == 0)    return Ackermann(m - 1, 1);
    else    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine("Enter your first num: ");
int num3_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second num: ");
int num3_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine($"A({num3_1},{num3_2}) = {Ackermann(num3_1, num3_2)}");