﻿//программа, принимающая трёхзначные числа 
//и выводящая последнюю цифру этого числа

int TakeNum(int num)
{
    Console.WriteLine(num);
    return  num % 10; 
    //10 - забирает последнюю цифру(пример 123 %10 -> 3)
    //123/10 -> 12
}

int th_num = new Random().Next(100, 1000);
int result=TakeNum(th_num);
Console.WriteLine(result);