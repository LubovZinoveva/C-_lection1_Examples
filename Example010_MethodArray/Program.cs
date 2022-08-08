// есть одномерный массив array из n эл-ов, найти элемент массива равный find 

int [] array  = {1, 58, 7, 54, 88, 2, 6, 71};
int n = array.Length;
int find = 2;
for (int index = 0; index < n; index ++)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
}

