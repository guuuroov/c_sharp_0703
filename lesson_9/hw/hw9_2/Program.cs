﻿//Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int sum(int m, int n)
{
if (m==n)
return n;
else return m + sum(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равна: {sum(m,n)}");