Console.Clear();

Console.Write("Введите номер, обозначающий день недели: ");
string a = Console.ReadLine();
int resultA = int.Parse(a);

if (resultA > 0 && resultA < 8)
{
    if (resultA >= 1 && resultA <= 5)
    {
        Console.WriteLine("Нет, данный день недели не является выходным днём, это рабочий день.");
    }
    else
    {
        Console.WriteLine("Да, данный день недели является выходным днём");
    }
}
else
{
    Console.WriteLine("Введенный номер дня недели не существует.");
    Console.WriteLine("Запустите программу заново и введите существующий номер дня недели.");
}