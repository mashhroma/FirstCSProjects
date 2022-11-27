// Это уже моя четвертая программа))))
Console.Write("Введите Ваше имя: ");
string name = Console.ReadLine();
if(name.ToLower() == "пепси")
{
    Console.WriteLine("Привет, черный котик Пепси))))))");
}
else
{
    if(name.ToLower() == "Чубик")
    {
        Console.WriteLine("Привет, рыжий котик Чубик))))))");
    }
    else
    {
        if(name.ToLower() == "андрей")
            Console.WriteLine("Привет, мой любимый Андрюшка))))))");
        else
        {
            Console.Write("Привет, ");
            Console.WriteLine(name);
        }
    }
}