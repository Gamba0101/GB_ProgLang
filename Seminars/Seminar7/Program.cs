// задайте двумерный массив размером mxn, заполненый случайными числамию

/*
int[,] Create2DArray () {
    Console.WriteLine("Enter count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collums: ");
    int collums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min amount: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max amount: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] new2DArray = new int [rows, collums];

    for (int i = 0; i < rows; i++) {
        for(int j = 0; j < collums; j++) {
            new2DArray[i,j] = new Random().Next(min,max + 1);
        }
    }
    return new2DArray;
}
*/

void Print2DArray (double[,] ar2D) {
    for (int i = 0; i < ar2D.GetLength(0); i++) {
        for(int j = 0; j < ar2D.GetLength(1); j++) {
            Console.Write(ar2D[i,j] + "  ") ;
        }
        Console.WriteLine(); // jump output to next line
    }
    Console.WriteLine(); // jump output to next line
}

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле А = m+n
/*
int[,] FillArray (){
    Console.WriteLine("Enter count of rows: ");
    int mRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collums: ");
    int nCollums = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int [mRows, nCollums];

    for (int i = 0; i < mRows; i++) {
        for(int j = 0; j < nCollums; j++) {
            newArray[i,j] = i + j;
        }
    }
    return newArray;
}
*/

// Задайте двумерный вещественный массив, найдите элементы у которых оба индекса четные и замените эти эл на их квадраты

double[,] CreateSquaredArray () {
    Console.WriteLine("Enter count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collums: ");
    int collums = Convert.ToInt32(Console.ReadLine());

    double[,] new2DArray = new double [rows, collums];

    for (int i = 0; i < rows; i++) {
        for(int j = 0; j < collums; j++) {
            new2DArray[i,j] = Math.Round((new Random().NextDouble()), 2);
        }
    }
    return new2DArray;

}

double [,] ModifyArray (double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            if ( i%2 == 0 && j%2 == 0) {
            array[i,j] *= array[i,j];
            array[i,j] = Math.Round(array[i,j], 4);
            }
        }
    }
    return array;
}

double [,] array3 = CreateSquaredArray();
Print2DArray(array3);
double [,] modifiedArray3 = ModifyArray(array3);
Print2DArray(modifiedArray3);
