int[] CreateNewArray (int size, int minV, int maxV) {
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++) {
        newArray[i] = new Random().Next(minV, maxV + 1);
    }
    return newArray;
}

void ShowArray (int[] arrayShow) {
    Console.Write("[ ");
    for (int i = 0; i < arrayShow.Length; i++) {
        Console.Write(arrayShow[i]);
        if (i!= arrayShow.Length - 1) Console.Write(", ");
        else Console.Write(" ]");
    }
    Console.WriteLine(" ");    
}

int[] ReverseArray (int[] arrayR) {
    for (int i = 0; i < arrayR.Length/2; i++){
        int temp = arrayR[i];
        arrayR[i] = arrayR[arrayR.Length - 1 - i];
        arrayR[arrayR.Length - 1 - i] = temp;
    }
    return arrayR;
}

int array_size = 7;
int min = -9;
int max = 9;

Console.Write("Your array is: ");
int[] CreatedArray = CreateNewArray(array_size, min, max);
ShowArray(CreatedArray);
Console.Write("Your array reversed is: ");
int[] ReversedArray = ReverseArray(CreatedArray);
ShowArray(ReversedArray);
