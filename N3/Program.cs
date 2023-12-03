// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int [,] Create2dArray(int row, int col, int min, int max)
{
    int [,] array = new int [row,col];
    for (int i = 0; i<row; i++)
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
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void ShowArray(int [] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]!=0)
        {
            if(i>0)
            {
                Console.Write("; ");
            }
            Console.Write(array[i]);
        }
    }
    Console.WriteLine();

}


int [] MyArray(int[,] array)
{
    int sum = 0; // сумма элементов предыдущей строки
    int [] minSum_row = new int[array.GetLength(0)];
    int count_row = 0;

    for(int i = 0; i<array.GetLength(0); i++)
    {
        int temp_sum = 0; // сумма элементов актуальной строки
        for(int j = 0; j<array.GetLength(1); j++)
        {
            temp_sum += array[i,j];
        }
       
        if (i==0) // для первой строки
        {
            sum = temp_sum;
            minSum_row[0]=1;
            count_row++;
        }
        else
        {
            if (temp_sum<sum)
            {
                minSum_row = new int[array.GetLength(0)-i];
                count_row = 0;
                sum = temp_sum;
                minSum_row[count_row] = i+1;
                count_row++;
            }
            else  if (temp_sum==sum)
            {
                minSum_row[count_row] = i+1;
                count_row++;
            }
        }

    }
    return minSum_row;

}

Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
if (row<3)
{
    Console.WriteLine("Wrong number row");
    return;
}
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
if (col<3)
{
    Console.WriteLine("Wrong number col");
    return;
}
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row,col,min,max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
int [] changedArr = MyArray(created2dArray);
Console.Write("Rows with minimal summ of elements: ");
ShowArray(changedArr);
