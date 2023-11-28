//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементами массива.


using System.ComponentModel.DataAnnotations;

double [] CreateArray(int min, int max, int size)
{
    double [] array = new double[size];

    for(int i = 0; i<size; i++)
    {
        int int_number = new Random().Next(min, max);

        double double_number = new Random().NextDouble();

        array[i] = int_number + Math.Round(double_number,2);

    }
    return array; 
}

double CalculateMaxMin(double [] array)
{
    double maximum = array[0];
    double minimum = array[0];

    for(int i = 1; i<array.Length; i++)
    {
        if(array[i] > maximum)
        {
           maximum = array [i];
        }
        if(array[i] < minimum)
        {
            minimum = array [i];
        }
    }
    
    double calculate = maximum - minimum; 

    return calculate;
}


void ShowArray(double [] array)
{
    
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

double [] array = CreateArray(min, max, size);
ShowArray(array);

double calculatedValue = CalculateMaxMin(array);
Console.WriteLine(calculatedValue);

