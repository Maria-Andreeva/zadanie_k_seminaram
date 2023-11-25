//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1, 4


Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine());
int temp = 1;
int i;

for (i=1; i<=N; i++)
{
    temp = i*i;
    Console.Write(temp);

    if(i<N)
    {
        Console.Write(", ");
    }
}


