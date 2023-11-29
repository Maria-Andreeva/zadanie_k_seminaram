// Задача 4: Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

int [] CreateArray(string stroka)
{
    int [] array = new int [stroka.Length];
    for(int i = 0; i < stroka.Length; i++)
    {
        array[i] = Convert.ToInt32(stroka[i].ToString());
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

Console.Write("Enter a number from 1 to 100 000: ");
int number = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(number.ToString()); 

ShowArray(array);





