﻿//Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine());
int temp = 1;
int i;

for (i=1; i<=N; i++)
{
    temp = temp * i;
}

Console.WriteLine(temp);