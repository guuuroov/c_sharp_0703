﻿// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.
Console.WriteLine("Write a number1: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write a number2: ");
int num2 = int.Parse(Console.ReadLine()!);

if ((num1 * num2) == num1)
{
  Console.WriteLine("yes");
}
else
{
  Console.WriteLine("no");
}