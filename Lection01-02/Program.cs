// Сравниваем 9 чисел и находим самое большое из них в массиве по индексу и по значению

int[]MyNumbers = {9,2,4,5,6,88,5,33,24};

int FindMax (int[]array)
{
    int MaxIndex = 0;
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        if (array[MaxIndex] < array[index]) MaxIndex = index;
        index++;
    }
    return MaxIndex;
}

int SuperMax = FindMax(MyNumbers);

Console.WriteLine(SuperMax);
Console.WriteLine(MyNumbers[SuperMax]);