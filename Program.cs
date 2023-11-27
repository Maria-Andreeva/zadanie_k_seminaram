//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int N = 122622645;
int temp = N;
string result = "";

do
{
    int rest = temp % 10;
    result += $"{rest}";
    temp = temp / 10; 
    
    if(temp > 0)
    {
        result += " ,";
    } 

}while (temp>0);

for (int i = result.Length - 1; i + 1> 0 ; i--)
{
    Console.Write(result[i]);
}