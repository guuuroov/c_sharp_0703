//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int x = num;

if((x % 2) ==0)
{
  Console.WriteLine("Да, число чётное");
}
else
{
  Console.WriteLine("Нет, число нечётное");
}

