//Напишите программу, которая на вход принимает трехзначное целое число, 
//и на выходе показывает сумму первой и последней цифры этого числа.
// 456 -> 10
// 782 -> 9
// 918 -> 17

Console.WriteLine("Введите трехзначное целое число");

int num = Convert.ToInt32(Console.ReadLine());

int temp = num % 10;
int tem = num / 100;
int result = temp + tem;

if(num >= 100 && num <= 999)
{
    Console.WriteLine(result);
}

else
{
    Console.WriteLine("Неверно указано число");
}
