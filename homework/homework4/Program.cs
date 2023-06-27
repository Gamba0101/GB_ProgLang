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

int DigitCount (int arg) {
    int i = 0;
    int res = 0;
    while (arg > 0 ){
        res = res + arg%10;
        arg = arg / 10;
        i++;
    }
    return res;
} 

if (num2 > 0) Console.WriteLine($"The sum of all the digits in {num2} equals to {DigitCount(num2)}");
else Console.WriteLine("ERROR: Your number must be more than 0.");


/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine(" ");
Console.WriteLine("EXERCISE 29");

int size = new Random().Next(3,16);

int[] CreateArray (int size){
    int[] temp_ar = new int[size];
    for (int i = 0; i < size; i++) {
        temp_ar[i] = new Random().Next(1,100);
    }
    return temp_ar;
}

void PrintArray (int[] print_ar) {
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < print_ar.Length; i++) {
        Console.Write(print_ar[i] + " ");
    }
}

int[] firstArray = CreateArray(size);
PrintArray(firstArray);