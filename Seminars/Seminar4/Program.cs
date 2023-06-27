/* void SumOfNum (int arg) {
    int Sum = 0;
    while (arg > 0) {
        Sum = Sum + arg;
        arg--;
    }
    Console.WriteLine(Sum);
}

Console.WriteLine("Input your num");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0){
    SumOfNum(num);
} else Console.WriteLine("ERROR: input a positive number.");*/

/* alternitive way: through a FOR cicle 

void SumOfNum (int arg) {
    int Sum = 0;
    for (int i = 1; i <= num_a; i++) {
        Sum += i; // sum = sum + i
    }
    Console.WriteLine(Sum);
}

*/

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

int size = 8;
int[] firstArray = CreateArray(size);
PrintArray(firstArray);
