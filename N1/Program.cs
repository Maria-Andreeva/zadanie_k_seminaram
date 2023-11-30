// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
//5 12 16 q [STOP]
//3 45 342 15 [STOP]

while (true)
{
    Console.Write("Enter array whole number: ");

    string? temp = Console.ReadLine();

    if (temp != null)
    {
        Console.WriteLine(temp);

        if(temp=="q")
        {
            break;
        }
    
        int sum = 0;

        for(int i = 0; i < temp.Length; i++)
        {
            sum += Convert.ToInt32(temp[i]);
        }        
        

        // for(int i = temp.Length -1; i>0; i--)
        // {
        //     sum += Convert.ToInt32(temp[i-1]);
        // }

        if(sum%2==0)
        {
            break;
        }
    }

}


