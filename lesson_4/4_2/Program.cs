// программа принимающая число (n) и выдающая произведения его чисел от 1 до n

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

int MultNum(int n)
{
  int mult = 1;
  for(int i=1; i<=n; i++)
  {
    mult=mult*i;
  }
  return mult;
}

int num = GetNum();
int dig = MultNum(num);
Console.WriteLine("Произведение цифр числа: " + dig);