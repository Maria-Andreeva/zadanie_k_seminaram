// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

using System.Runtime.Serialization.Formatters;

int [] CreateArray(int max, int min, int size) 
{
    int [] array = new int [size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array; 
}



int CheckArray(int[] array) 
{
  int result = 0;
  for(int i = 0; i<array.Length; i++)
  {
    if(array[i] % 2 == 0)
    {
      result++;
    }
  }
  return result;
}


void ShowArray(int [] array)
{
    
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(max, min, 10);
ShowArray(arr);

int count = CheckArray(arr);
Console.WriteLine ($"Numbers of elements: {count}");
