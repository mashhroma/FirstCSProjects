// Крестики-нолики

void PrintTicTac(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
//                 0    1    2    3    4    5    6    7    8
char[] arrayA = { 'a', '|', ' ', '|', ' ', '|', ' ', '|' };
char[] arrayB = { 'b', '|', ' ', '|', ' ', '|', ' ', '|' };
char[] arrayC = { 'c', '|', ' ', '|', ' ', '|', ' ', '|' };

int countX = 0;
int countO = 0;
int col = 0;
char line = ' ';

Console.WriteLine("Введите ячейку, куда поставите О или Х.");
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    while (countX == 0)
    {
        Console.Write("ПЕРВЫЙ ИГРОК - Х: ");
        string iks = Console.ReadLine()!;
        line = iks[0];
        if (iks[1] == '1') col = 2;
        else if (iks[1] == '2') col = 4;
        else if (iks[1] == '3') col = 6;
        else Console.WriteLine("not a correct number");

        if (line == 'a')
        {
            if (arrayA[col] == 'x' || arrayA[col] == 'o') Console.WriteLine("Ячейка занята, выберите другую ячейку");
            else countX = 1;
        }
        else if (line == 'b')
        {
            if (arrayB[col] == 'x' || arrayB[col] == 'o') Console.WriteLine("Ячейка занята, выберите другую ячейку");
            else countX = 1;
        }
        else if (line == 'c')
        {
            if (arrayC[col] == 'x' || arrayC[col] == 'o') Console.WriteLine("Ячейка занята, выберите другую ячейку");
            else countX = 1;
        }
        else Console.WriteLine("not a correct number");
    }

    if (line == 'a') arrayA[col] = 'x';
    if (line == 'b') arrayB[col] = 'x';
    if (line == 'c') arrayC[col] = 'x';

    Console.WriteLine(" |1|2|3|");
    Console.WriteLine("---------");
    PrintTicTac(arrayA);
    Console.WriteLine("---------");
    PrintTicTac(arrayB);
    Console.WriteLine("---------");
    PrintTicTac(arrayC);
    Console.WriteLine("---------");

    while (countO == 0)
    {
        Console.Write("ВТОРОЙ ИГРОК - О: ");
        string zero = Console.ReadLine()!;
        line = zero[0];

        if (zero[1] == '1') col = 2;
        else if (zero[1] == '2') col = 4;
        else if (zero[1] == '3') col = 6;
        else Console.WriteLine("not a correct number");

        if (line == 'a')
        {
            if (arrayA[col] == 'x' || arrayA[col] == 'o') Console.WriteLine("Ячейка занята, выберите другую ячейку");
            else countO = 1;
        }
        else if (line == 'b')
        {
            if (arrayB[col] == 'x' || arrayB[col] == 'o') Console.WriteLine("Ячейка занята, выберите другую ячейку");
            else countO = 1;
        }
        else if (line == 'c')
        {
            if (arrayC[col] == 'x' || arrayC[col] == 'o') Console.WriteLine("Ячейка занята, выберите другую ячейку");
            else countO = 1;
        }
        else Console.WriteLine("not a correct number");
    }

    if (line == 'a') arrayA[col] = 'o';
    if (line == 'b') arrayB[col] = 'o';
    if (line == 'c') arrayC[col] = 'o';

    Console.WriteLine(" |1|2|3|");
    Console.WriteLine("---------");
    PrintTicTac(arrayA);
    Console.WriteLine("---------");
    PrintTicTac(arrayB);
    Console.WriteLine("---------");
    PrintTicTac(arrayC);
    Console.WriteLine("---------");

    countO = 0;
    countX = 0;
}