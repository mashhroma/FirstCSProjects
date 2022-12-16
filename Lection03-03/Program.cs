// Таблица умножения
Console.WriteLine("ТАБЛИЦА УМНОЖЕНИЯ");

for (int i = 1; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        int product = i*j;
        if (product>9 && i>9 && j>9) Console.Write(j + " X " + i + " = " + product + "| ");
        else if (product>9 && i>0 && j>9) Console.Write(j + " X " + i + " = " + product + "  | ");
        else if (product>9 && i>9 && j>0) Console.Write(j + " X " + i + " = " + product + "   | ");
        else if (product>9 && i>0 && j>0) Console.Write(j + " X " + i + " = " + product + "    | ");
        else Console.Write(j + " X " + i + " = " + product + "     | ");
    }
     Console.WriteLine();
}