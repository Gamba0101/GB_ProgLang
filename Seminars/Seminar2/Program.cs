// finding the biggest random number from [10,99] and shows its maximum number

/* int Line() {
    int num = new Random().Next(10,100);
    Console.WriteLine("Your number is " + num);
    int dec = num/10;
    int yet = num % 10;
    if(dec > yet){
        return dec;
    } else {
        return yet;
    }
}; 

Console.WriteLine("Result is - " + Line()); */

// Write a programm that gets an input of a number and deletes its second number
int num = new Random().Next(100,1000);
Console.WriteLine("Your number is:" + num);

int hun = num/100;
int ten = num/10 % 10;
int ed = num %10;

Console.WriteLine(hun.ToString() + ed.ToString());


// Write a programm that resieves on input two numbers and output does the 1st num divide by the 2nd num.
// If not then it will output остаток from the division


Console.WriteLine("Please, input your 1st number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, input your 2nd number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 != 0 && num1 != 0){
if (num2 % num1 == 0){
    Console.WriteLine("Your number is dividable"); 
} else {
    Console.WriteLine("Остаток = " + num2 % num1);
}} else {
    Console.WriteLine("You can't divide by zero");
};