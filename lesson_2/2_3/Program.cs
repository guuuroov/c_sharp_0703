// программа, принимающая на вход число и показывающая,
// кратно ли оно 7 и 23 одновременно

//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine()!); //Можно использовать такой вариант, для ввода числа вручную

int num = new Random(). Next(100, 1000); //рандомное число в заданном диапазоне

void MyFunc(int num)
{
  Console.WriteLine("Your number:" + num);

  if(num%7 ==0 && num%23 ==0)
{
  Console.WriteLine("Yes");
}
else{
  Console.WriteLine("No");
}
}

MyFunc(num);