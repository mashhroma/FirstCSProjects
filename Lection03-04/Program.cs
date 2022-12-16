// Упорядочить массив от 

Console.WriteLine("Упорядочить массив.");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
    return array;
}

Console.WriteLine("Введите массив: ");
string addArray = Console.ReadLine()!;

int[] arr = new int[addArray.Length];
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(addArray[i].ToString());
    }

Console.WriteLine("Дан массив: ");
PrintArray(arr);

Console.WriteLine("Упорядочить массив от минимального к максимальному.");
PrintArray(SelectionSort(arr));