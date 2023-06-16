
//Console.WriteLine("What is the date?"); //write on line then enter new line
// Console.Write("Today is Friday!"); // write on line

// Console.ReadLine(); // - string
// int numA = Convert.ToInt32(Console.ReadLine()); // - int
// Console.WriteLine("Today is " + numA);
// Console.Write($"String is {numA}"); // $" {}" - symbol that allows us to include a number in our string w/o changing the type

// Exersice 1: find the square of inputted number
/* int numA = Convert.ToInt32(Console.ReadLine());
   int res = numA * numA;
   Console.WriteLine(res); */

// Exercise 2: Get two numbers from user and check if the second number is the square of first number

/* Console.WriteLine("Please, input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, input second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2){
    Console.WriteLine($"{num1} is a square of {num2}"); 
} else {
    Console.WriteLine($"{num1} is NOT a square of {num2}"); 
}; */

// Exercise 3: input 1 num and outputs all numbers from -num to +num
/*
Console.WriteLine("Please, input your number:");
int num = Convert.ToInt32(Console.ReadLine());
int count = num * -1;

while (count <= num) {
    Console.Write($"{count} ");
    count = count + 1;
}; */ 

// Exercise 4: input a three digit number and output the last number of that number

Console.WriteLine("Please, input your 3 digit number:");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;
Console.WriteLine(result);


