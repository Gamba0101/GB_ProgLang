// задайте двумерный массив размером mxn, заполненый случайными числамию

// int[,] array = new(x,y); двумерный массив
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

void Print2DArray (int[,] ar2D) {
    for (int i = 0; i < ar2D.GetLength(0); i++) {
        for(int j = 0; j < ar2D.GetLength(1); j++) {
            Console.Write(ar2D[i,j] + "  ") ;
        }
        Console.WriteLine(); // jump output to next line
    }
    Console.WriteLine(); // jump output to next line
}

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле А = m+n

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

int[,] new2DArray = FillArray();
Print2DArray(new2DArray);