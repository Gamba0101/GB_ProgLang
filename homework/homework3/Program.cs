/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("EXERCISE 19");

Console.WriteLine("Please, input your 5 digit number:");
int num1 = Convert.ToInt32(Console.ReadLine());
int erCheck = 0;

if (num1 > 9999 && num1 <100000) {
    erCheck = 0;
} else {  
    Console.WriteLine("ERROR: type in 5 digit num");
    erCheck = 1;
    };

int Check (int arg) {
    int tth = arg / 10000;
    int th = arg / 1000 % 10;

    int ten = arg / 10 % 10;
    int one = arg % 10;

    if (tth == one && th == ten) {
        int result = 1;
        return result; }
    else {
        int result = 0;
        return result;}
};

if (Check(num1) == 1) Console.WriteLine("Yes, your number is палиндром");
else if (erCheck == 1) Console.WriteLine("Try again");
else Console.WriteLine("No, your number is not a палиндром");

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 21");


Console.WriteLine("Input your X coord (they cannot equal 0)");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your Y coord (they cannot equal 0)");
int yCoord = Convert.ToInt32(Console.ReadLine());



/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


Console.WriteLine(" ");
Console.WriteLine("EXERCISE 15");

Console.WriteLine("Please, input your number:");
int num3 = Convert.ToInt32(Console.ReadLine());

int i = 1;
int temp = 0;

Console.Write(num3 + " -" );

while (i <= num3) {
    temp = i * i * i;
    Console.Write(" " + temp);
    i++;
}

/* int FindCube (int num3) {
    int start = 1;
    int result = -1;
    while (start <= num3) {
        result = start * start * start;
        return result;
        start = start + 1;
    }
    return result;
} */
 
