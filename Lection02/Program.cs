// Простой метод, который возвращает самое большое число из трех

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int GetArg ()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Данная программа сравнивает заданные числа и Возвращает самое большое из них!");

int a1 = GetArg ();
int b1 = GetArg ();
int c1 = GetArg ();
int a2 = GetArg ();
int b2 = GetArg ();
int c2 = GetArg ();
int a3 = GetArg ();
int b3 = GetArg ();
int c3 = GetArg ();

int SuperMax = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));

Console.WriteLine($"Самое больше число: {SuperMax}");