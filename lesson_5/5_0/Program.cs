﻿//Массив из 12 элементов, заполненый случайными цифрами [9;-9]

void Print(int[] arr)
{
  int  size=arr.Length;

  for (int i =0; i<size; i++)
    Console.Write($"{arr[i]} ");
  Console.WriteLine();
}

int[] EightMass(int size, int from, int to)
{
    int[] arr = new int [size];

    for (int i = 0; i<size;i++)
      arr[i]=new Random().Next(from, to +1);
    return arr;
}

void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
          pos += arr[i];
        else
          neg += arr[i];
    }
    Console.WriteLine($"Pos: {pos}, Neg: {neg}");
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);
SumPosNeg(mass);