// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)


int [] InverseArray (int [] array)
{
    int [] temp_array = new int [array.Length]; 
    int size = array.Length - 1; 


    for(int i = 0; i <= size; i++)
    {
        temp_array[i] = array[size - i];
    }

    return temp_array;
}

int [] CreateArray(int min, int max, int size)
{
    int [] array = new int [size];

    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array; 
}

void ShowArray(int [] array)
{
    
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}


Console.Write("Enter array size: ");
int size1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter array min: ");
int min1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter array max: ");
int max1 = Convert.ToInt32(Console.ReadLine());


int [] array = CreateArray(min1, max1, size1);
int [] temp_array = InverseArray (array);
ShowArray(array);
ShowArray(temp_array);