// Строчный палидром

void PrintTurn (string text)
{
    int count = text.Length;
    for (int i=0; i < text.Length; i++)
    {
        Console.WriteLine($"| Буква {i+1} - {text[i]} | Буква {count} - {text[count - 1]} | ");
        count = count - 1;
    }
}

string DelSpace (string text)
{
    string result = string.Empty;
    for (int i=0; i < text.Length; i++)
    {
        if (text[i] != ' ') result = result + $"{text[i]}";
    }
    return result;
}

Console.Write("Введите слово, чтобы проверить является ли оно палиндромом: ");
string wordAdd = Console.ReadLine()!;

Console.WriteLine();

string word = DelSpace(wordAdd);

PrintTurn(word);

int j = word.Length;

for (int i = 0; i < word.Length; i++)
{
    if (word[i] != word[j - 1])
    {
        Console.WriteLine($"Данное слово/фраза {wordAdd} - это НЕ палиндром!");
        break;
    }
    else if (word[i] == word[j - 1] && i > word.Length / 2)
    {
        Console.WriteLine($"Данное слово/фраза {wordAdd} - это палиндром!");
        break;
    }
    else
    {
        j = j - 1;
    }
}