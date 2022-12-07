int[]array = {1,12,22,4,53,57,22};

int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
