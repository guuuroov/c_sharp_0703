// программа, принимающая координаты х и у(не равные нулю) и выдающая номер четверти плоскости, в которой они находятся
// четверти расположены против часовой стрелки!!!

void Quarters(int x, int y)
{
  if(x==0 || y==0)
    Console.WriteLine("x=0,y=0");
  else if(x>0 && y>0)
    Console.WriteLine("I");
  else if(x<0 && y>0)
    Console.WriteLine("II");
  else if(x<0 && y<0)
    Console.WriteLine("III");
  else if(x>0 && y<0)
    Console.WriteLine("IV");
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Quarters(num1, num2);