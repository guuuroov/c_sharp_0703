// Программа, выводящая массив из 8 элементов, состоящий из 0 и 1
// в случайном порядке

int GenNum()
{
  int number = new Random().Next(2);
  return number;
}

int[] MakeArray()
{
  int[] arr = new int[8];
  for(int i=0;i<8; i++)
  {
    arr[i]=GenNum();
  }
  return arr;
}
void PrintArray(int[] array)
{
  for(int i =0; i< array.Length; i++)
  {
    Console.Write($" {array[i]}");
  }
  Console.WriteLine();
}

PrintArray(MakeArray());