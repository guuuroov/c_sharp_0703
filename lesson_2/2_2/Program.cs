// программа, которая принимает 2 числа
// и выводит, является ли второе число кратным первому

int num1 = int.Parse(Console.ReadLine()!); //запрос ввода числа
int num2 = int.Parse(Console.ReadLine()!); //запрос ввода числа

if(num1%num2 == 0) //кратность всегда %, 0 - деление без остатка
{
  Console.WriteLine("Yes");
}
else
{
  Console.WriteLine("No, "+ num1%num2);
}