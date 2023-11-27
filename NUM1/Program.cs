﻿// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int [] array = 10;
// int min = 1;
// int max = 100;
// size = [20,90];


int [] CreateArray(int max, int min, int size) 
{
    int [] array = new int [size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array; 
}

int CheckArray(int[] array, int min, int max) 
{
    int count = 0;

    for(int i = 0; i<array.Length; i++)
    {
        if (array [i] >= 20 && array [i] <= 90)
        {
            count++;
        }
          
    }

    return count; 
}

void ShowArray(int [] array)
{
    
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] array = CreateArray(100, 1, 10);

int count = CheckArray(array, 20, 90);

ShowArray(array);

Console.WriteLine ($"Numbers of elements: {count}");


