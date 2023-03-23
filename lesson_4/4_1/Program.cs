//Программа, принимающая число и выдающая количество цифр в нём

int GetNum()
{
  int number = 0;
  while(number ==0)
  {
    Console.Write("Введите число: ");
    number = int.Parse(Console.ReadLine()!);
  }
  return number;
}

int CountNum(int n)
{
  int count =0;
  while (n>0)
  {
    n = n/10;
    count++;
  }
  return count;
}

int num = GetNum();
int dig = CountNum(num);
Console.WriteLine("Цифр в числе: " + dig);