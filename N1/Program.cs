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
        else if (Int32.TryParse(temp, out int dummy))
        {
            int sum = 0;

            for(int i = 0; i < temp.Length; i++)
            {
                int number;

                if(Int32.TryParse(temp[i].ToString(), out number) )
                {
                    sum += number;
                } 
            }        
        
            if(sum%2==0)
            {
                break;
            } 
        }
        else
        {
            Console.WriteLine("Wrong number");
        }

        
    }
}




