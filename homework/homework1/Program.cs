/* Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("EXERCISE 2");

Console.WriteLine("Please, input first number:");
int num1_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, input second number:");
int num1_2 = Convert.ToInt32(Console.ReadLine());

if (num1_1 > num1_2) {
        Console.WriteLine($"max = {num1_1}");
        Console.WriteLine($"min = {num1_2}"); 
} if (num1_2 > num1_1) {
        Console.WriteLine($"max = {num1_2}");
        Console.WriteLine($"min = {num1_1}"); 
} else {
    Console.WriteLine($"{num1_1} = {num1_2}");
}; 

/* Задача 4: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("EXERCISE 4");

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

Console.WriteLine("EXERCISE 6");

Console.WriteLine("Please, input your number:");
int num3 = Convert.ToInt32(Console.ReadLine());
int res = num3 % 2;

if (res == 0) {
    Console.WriteLine($"{num3} is even"); 
} else {
    Console.WriteLine($"{num3} is odd"); 
};

/* Задача 8: 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("EXERCISE 8");

Console.WriteLine("Please, input your number:");
int num4 = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num4) {
    int temp = count % 2;
    if (temp == 0) {
    Console.Write($"{count}, ");
    count = count + 1;
    } else {
    count = count + 1; }
};
