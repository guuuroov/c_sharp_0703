//  Программа, принимающая номер четверти системы координат
// и выдающая диапазон возможных координат

GetQuarter();

void GetQuarter()
{
  Console.Write("Enter quarter: ");
  int q = int.Parse(Console.ReadLine()!);
  if(q < 1 || q > 4)
  {
    Console.WriteLine("Error! Quarter not found");
  }
  else
  {
    switch(q)
    {
      case 1:
        Console.WriteLine("x>0;y>0");
        break;
      case 2:
        Console.WriteLine("x<0;y>0");
        break;
      case 3:
        Console.WriteLine("x<0;y<0");
        break;
      case 4:
        Console.WriteLine("x>0;y<0");
        break;
      
    }
  }
}

