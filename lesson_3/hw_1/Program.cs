﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите пятизначное значное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " - является палиндромом");
    }

    else
    {
        Console.WriteLine(number + " - не является палиндромом");
    }
}
else
{
    Console.WriteLine ("Ошибка! Введите пятизначное число!");
}