/*
// void - Невозвратный метод
void NameFunk() { //NameFunk - название; () - аргументы (им не необходимо быть) - значения, которая программа берет извне
    body;
}; 

NameFunk(); // вызов метода (он не вернет результат)
*/

// Напишите прог которая на вход принимает координаты точки (Х & Y)
// и выводит номер в какой четверти находится координата

int Koord (int X, int Y){
    int numQuarter;
    if (X > 0 && Y > 0)
        numQuarter = 1;
    else if (X < 0 && Y > 0)
        numQuarter = 2;
    else if (X < 0 && Y < 0)
        numQuarter = 3;
    else 
        numQuarter = 4;

    return numQuarter;

};

Console.WriteLine("Input your X coord (they cannot equal 0)");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your Y coord (they cannot equal 0)");
int yCoord = Convert.ToInt32(Console.ReadLine());

if (xCoord == 0 || yCoord == 0) {
    Console.WriteLine("ERROR");
} else {
int numQuart = Koord(xCoord, yCoord);
Console.WriteLine($"Your coords are in {numQuart} quarter");
}