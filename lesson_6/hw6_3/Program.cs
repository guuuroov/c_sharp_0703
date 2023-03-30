// Напишите программу, 
//которая будет создавать копию заданного двумерного массива 
//с помощью поэлементного копирования.


int[,] originalArray = new int[,]
{{1,2,3},{4,5,6},{7,8,9}};
int[,] copiedArray = new
int [originalArray.GetLength(0),originalArray.GetLength(1)];

Console.WriteLine("Оригинал массива: ");
for(int i = 0; i < originalArray.GetLength(0);i++)
{
  for(int j = 0; j < originalArray.GetLength(1);j++)
  {
    Console.Write(originalArray[i,j]+ ", ");
  }
  Console.WriteLine();
}
Console.WriteLine("Копия массива: ");
for(int i = 0; i < originalArray.GetLength(0);i++)
{
  for(int j = 0; j < originalArray.GetLength(1);j++)
  {
    copiedArray[i,j] = originalArray[i,j];
    Console.Write(copiedArray[i,j]+ ", ");
  }
  Console.WriteLine();
}

