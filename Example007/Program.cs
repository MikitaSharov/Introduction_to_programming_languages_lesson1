int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 13;
int b1 = 143;
int c1 = 134;
int a2 = 313;
int b2 = 14;
int c2 = 340;
int a3 = 130;
int b3 = 123;
int c3 = 321;

int result = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(result);