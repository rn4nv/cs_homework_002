Console.Clear();

Console.Write("Введите число: ");
string a = Console.ReadLine();
int resultA = int.Parse(a);

// Так как в условиях задачи не было конкретно указано, скольки значное число будет являться введенное число,
// но в примере было указано самое максимальное число пятизначное. Поэтому программа работает при трех-, четырех- и пятизначном числе.

if (resultA >= 100 && resultA <=999)
{
    resultA = (resultA % 100);
    resultA = (resultA % 10);
    Console.Write("Третья цифра введенного числа равна: ");
    Console.Write(resultA);
}
else 
{
    if (resultA >= 1000 && resultA <= 9999)
    {
        resultA = (resultA % 1000);
        resultA = (resultA % 100);
        resultA = (resultA / 10);
        Console.Write("Третья цифра введенного числа равна: ");
        Console.Write(resultA);
    }
    else
    {
        if (resultA >= 10000 && resultA <= 99999)
        {
            resultA = (resultA % 10000);
            resultA = (resultA % 1000);
            resultA = (resultA / 100);
            Console.Write("Третья цифра введенного числа равна: ");
            Console.Write(resultA);
        }
        else
        {
            if (resultA > 1000000)
            {
                Console.WriteLine("Введенное число на порядок превышает пятизначное число. Запустите программу заново и введите новое число, не превышающее пятизначное: ");
            }
            else
            {
                Console.WriteLine("Введенное число двузначное. В нем отсутсвует третья цифра.");
            }
        }
    }
}