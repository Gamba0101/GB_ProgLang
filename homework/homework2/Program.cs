﻿/* Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("EXERCISE 10");

Console.WriteLine("Please, input your 3 digit number:");
int num1 = Convert.ToInt32(Console.ReadLine());

int ten = num1/10 % 10;

Console.WriteLine("Second digit in your number is - " + ten);

/* Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("EXERCISE 13");

Console.WriteLine("Please, input your number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num2) {
    int result = -1;
    if (num2 >= 100) {
        while (num2 > 999) {
            num2 = num2 / 10;
            }
        result = num2 % 10;
        }
    return result; 
    };

if (ThirdDigit(num2) == -1) {
    Console.WriteLine("There is no 3rd digit"); 
    } else {
    Console.WriteLine(ThirdDigit(num2));
};

/* Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("EXERCISE 15");

Console.WriteLine("Please, input a number from 1 to 7:");
int num3 = Convert.ToInt32(Console.ReadLine());

if (1 <= num3 && num3 < 6) {
    Console.WriteLine("no, this is not the weekend");
}else {
    Console.WriteLine("yes, this is the weekend");
};
