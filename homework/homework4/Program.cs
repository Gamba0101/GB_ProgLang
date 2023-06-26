/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("EXERCISE 25");

Console.WriteLine("Input your first number: ");
int num1_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your second number: ");
int num1_2 = Convert.ToInt32(Console.ReadLine());

void Exponentiate (int arg1, int arg2) {
    int i = 1;
    int sum = 1;
    while (i <= arg2) {
        sum = sum * arg1;
        i++;
    }
    Console.WriteLine($"{num1_1} to power of {num1_2} is {sum}");
};

if (num1_2 <= 0) Console.WriteLine("ERROR: your second number must be more than 0.");
else if (num1_1 <= 0) Console.WriteLine("ERROR: your first number must be more than 0.");
else Exponentiate(num1_1, num1_2);

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 27");

Console.WriteLine("Input your num: ");
int num2 = Convert.ToInt32(Console.ReadLine());



/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 29");

Console.WriteLine("Input your num: ");
int num3 = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[8];
// int num = new Random().Next(1,100); 