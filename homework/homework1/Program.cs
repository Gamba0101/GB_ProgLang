/* Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
/*
Console.WriteLine("Please, input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, input second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) {
        Console.WriteLine($"max = {num1}");
        Console.WriteLine($"min = {num2}"); 
} if (num2 > num1) {
        Console.WriteLine($"max = {num2}");
        Console.WriteLine($"min = {num1}"); 
} else {
    Console.WriteLine($"{num1} = {num2}");
}; */

/* Задача 4: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Please, input first number:");
int num2_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, input second number:");
int num2_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, input third number:");
int num2_3 = Convert.ToInt32(Console.ReadLine());

if (num2_1 > num2_2 && num2_1 > num2_3) {
    Console.WriteLine($"max = {num2_1}");
} if (num2_2 > num2_1 && num2_2 > num2_3) {
    Console.WriteLine($"max = {num2_2}");
} if (num2_3 > num2_1 && num2_3 > num2_2) {
    Console.WriteLine($"max = {num2_3}");
} if (num2_1 == num2_2 || num2_2 == num2_3 || num2_3 == num2_1) {
    Console.WriteLine("The numbers need to be different");
}; 

/* Задача 6: 
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */


/* Задача 8: 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

