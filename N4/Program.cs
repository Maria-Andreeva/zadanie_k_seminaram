// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

Console.Clear();

int [,] Create2dArray(int row, int col, int min, int max)
{
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++)
    {
        for(int j = 0; j<col;j++)
        {
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int [,] MyArray(int[,] array)
{
    int min = array[0,0];

    int rowIndex = 0;
    int colIndex = 0;

    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            {
                rowIndex = i;
                colIndex = j;
                min = array[i,j];
            }
        }
    }
    
    Console.WriteLine(rowIndex);
    Console.WriteLine(colIndex);

    int [,] temp_array = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];

    for(int i = 0; i<array.GetLength(0); i++)
    {
        if(i == rowIndex)
        {
            continue;
        }

        for(int j = 0; j<array.GetLength(1); j++)
        {
            if( j == colIndex)
            {
               continue;
            }

           if (i < rowIndex)
           {
                if (j < colIndex)
                {
                    temp_array[i, j] = array[i, j];
                }
                else
                {
                    temp_array[i, j - 1] = array[i, j];
                }
           }
           else
           {
                if (j < colIndex)
                {
                    temp_array[i - 1, j] = array[i, j];
                }
                else
                {
                    temp_array[i - 1, j - 1] = array[i, j];
                }
           }
        }
    }

    return temp_array;
}

Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row,col,min,max);

Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
int [,] changedArr = MyArray(created2dArray);
Show2dArray(changedArr);