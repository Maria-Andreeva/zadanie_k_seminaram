//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System.Runtime.Serialization;

Console.Clear();

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void SearchElement(int[,] array, int i_zadan, int j_zadan)  // создаем метод, который принимает массив с заданными индексами
{
    if (i_zadan>array.GetLength(0)-1 || j_zadan>array.GetLength(1)-1)  // при значениях, выходящих за границы массива, искомые значения не могут быть найдены
    {
        Console.WriteLine ("Wrong index elements");
    }

    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            if (i == i_zadan && j == j_zadan) // сравниваем индексы имеющегося массива с искомыми индексами и находим элемент
            {
                Console.WriteLine(array[i,j]);
            }
        }
    }

}

Console.WriteLine("Enter row index numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col index numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row,col,min,max);

Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
SearchElement(created2dArray, 1, 5);  // указываем массив и задаем искомые индексы элементов массива

