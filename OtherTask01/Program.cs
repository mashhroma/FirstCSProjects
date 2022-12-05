// Наибольший делитель для 4-х чисел

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

Console.Write("Введите четвертое число: ");
int d = int.Parse(Console.ReadLine()!);

int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

int div = max;

while (div > 0)
{
    if (a % div == 0 && b % div == 0 && c % div == 0 && d % div == 0)
    {
        Console.Write($"Общий делитель: {div}");
        break;
    }
    div = div - 1;
}