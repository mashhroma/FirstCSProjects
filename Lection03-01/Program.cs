// Методы и строки

string DiffText(string text, char oldSym, char newSym)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldSym) result = result + $"{newSym}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string myText = "Оборачиваемость товаров - это отношение скорости продажи товара к среднему запасу за определенный период."
            + "Оборачиваемость может измеряться в разах (сколько раз за период товар успевает обернуться) или в днях"
            + "(сколько дней нужно для продажи среднего запаса товара)";

string NewText = DiffText(myText, 'ч', 'Ч');

Console.WriteLine(NewText);

