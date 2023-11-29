// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

// void ShowArray(int [] array)
// {
    
//     for(int i = 0; i<array.Length;i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }


Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(999, 100, size);
// ShowArray(arr);

int count = CheckArray(arr);
Console.WriteLine ($"Numbers of elements: {count}");
