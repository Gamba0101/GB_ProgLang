// finding the biggest random number from [10,99] and shows its maximum number

int Line() {
    int num = new Random().Next(10,99);
    Console.WriteLine("Your number is " + num);
    int dec = num/10;
    int yet = num % 10;
    if(dec > yet){
        return dec;
    } else {
        return yet;
    }
};

Console.WriteLine("Result is - " + Line());