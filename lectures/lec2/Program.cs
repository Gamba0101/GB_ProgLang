int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {1, 201, 32, 4, 5, 16, 6, 8, 9};

int max = Max(Max(array[0], array[1], array[2]), 
              Max(array[3], array[4], array[5]), 
              Max(array[6], array[7], array[8])
              );

Console.WriteLine(max);

/*int a = 12;
int b = 13;
int c = 21;
int d = 123;
int e = 2;
int f = 32;
int g = 707;
int h = 201;
int i = 102; 

//int max1 = Max(a, b, c);
//int max2 = Max(d, e, f);
//int max3 = Max(g, h, i);

int max = Max(Max(a, b, c), 
              Max(d, e, f), 
              Max(g, h, i)
              );

Console.WriteLine(max); */