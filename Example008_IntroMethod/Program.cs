int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 3;
int b1 = 87;
int c1 = 32;

int a2 = 5;
int b2 = 8;
int c2 = 98;

int a3 = 36;
int b3 = 7;
int c3 = 4;

 int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));
 Console.Write(max);
