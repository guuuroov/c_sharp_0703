// Напишите программу, которая принимает на вход трёхзначное число и убирает вторую цифру из этого 
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int delsecDigit = ((num/100)*10)+(num%10);
Console.WriteLine("Новое число: " + delsecDigit);