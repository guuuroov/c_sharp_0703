//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);

if(num<=5)
{
  Console.WriteLine("Это будний день.");
}
else if(num <=6)
{
  Console.WriteLine("Это выходной день!");
}
else if(num<=7)
{
  Console.WriteLine("Это выходной день!");
}
else
{
  Console.WriteLine("Заданное число не соответствует количеству дней недели");
}