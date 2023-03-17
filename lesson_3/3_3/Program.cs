// программа выдающая таблицу квадратов заданного числа

Console.Write("Введите число: ");
void Pow(int num)
{
    int i=1;
    while(i<=num)
    {
        Console.WriteLine(Math.Pow(i,2));
        i++;
    }
}

int number=int.Parse(Console.ReadLine()!);
Console.WriteLine("Таблица квадратов: ");
Pow(number);