//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int result = 1;

if(result==1)
{
  result+= 1;
}
while (result<=num)
{
  Console.Write(result);
  result += 2;
}