// Программа принимающая число (а) и выдающая сумму чисел от 1 до (а)

Console.Write("Введите число: ");
int SumNum(int num)
{
  int sum_all = 0;

  for(int i = 1; i <= num; i++)
      sum_all +=i;

  return sum_all;
}

int val = int.Parse(Console.ReadLine()!);
int result = SumNum(val);
Console.WriteLine("Сумма чисел от 1 до введенного числа: " + result);