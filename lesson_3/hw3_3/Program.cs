//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
void Pow(int num)
{
    int i=1;
    while(i<=num)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }
}

int number=int.Parse(Console.ReadLine()!);
Console.WriteLine("Таблица кубов: ");
Pow(number);