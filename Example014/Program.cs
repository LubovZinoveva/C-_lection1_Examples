// упорядочивание наоборот от большего к меньшему

int [] arr = {5, 1, 4, 3, 2, 6, 7, 1, 1};

// Вывод массива на экран
void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

// Метод, кторый упорядочивает массив
void SelectionSort(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int minPosition = i;
        for(int j = i - 1; j >=0; j--)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array [i];
        array [i] = array [minPosition];
        array [minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);