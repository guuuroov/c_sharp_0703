// 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.
Console.WriteLine("Write a day number(1-7): ");
int daynum = int.Parse(Console.ReadLine()!);


if (daynum == 1)
{
  Console.WriteLine("Пн");
}
else if (daynum == 2)
{
  Console.WriteLine("Вт");
}
else if (daynum == 3)
{
  Console.WriteLine("Ср");
}
else if (daynum == 4)
{
  Console.WriteLine("Чт");
}
else if (daynum == 5)
{
  Console.WriteLine("Пт");
}
else if (daynum == 6)
{
  Console.WriteLine("Сб");
}
else if (daynum == 7)
{
  Console.WriteLine("Вс");
}
else
{
  Console.WriteLine("неизвестное число");
}