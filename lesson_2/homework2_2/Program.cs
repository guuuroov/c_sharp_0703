// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int thDigit = (num /100)%10;



if (thDigit ==0)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  Console.WriteLine("Третья цифра: " + thDigit);
}