//программа, выводящая случайное число из отрезка(10,99)
// и показывающая наибольшую цифру числа
int num = GenNum();
PrintNum(num);
int dig1 = GetFirstDigit(num);
int dig2 = GetSecDigit(num);
int max = Max(dig1, dig2);
PrintNum (max);


int GenNum()
{
    int number = new Random().Next(10,100);
    return number;
}
int GetSecDigit(int n)
{
    return n/10;
}
int GetFirstDigit(int n)
{
    return n%10;
}
int Max(int n1, int n2)
{
    if(n1>n2)
    {
      return n1;
    }
    return n2;
}

void PrintNum(int n)
{
  Console.WriteLine("Ваше число: " + n);
}
