Console.Clear();

Console.Write("Введите число: ");
string a = Console.ReadLine();
int resultA = int.Parse(a);

if (resultA >= 100 && resultA < 1000)
{
    resultA = (resultA % 100);
    resultA = (resultA / 10);
    Console.Write("Вторая цифра в введенном числе равна: ");
    Console.Write(resultA);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число. Запустите программу заново и введите трехзначное число.");
}