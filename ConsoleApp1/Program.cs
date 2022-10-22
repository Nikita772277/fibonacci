using System.Runtime.ExceptionServices;


void Fid()
{
    while (true)
    {
Console.Write("Введите число: ");
string a = Console.ReadLine();
bool b = int.TryParse(a, out int c);
int ferst = 0;
int gerst = 1;
int count = 0;
int result ;
        if(a==" " || a == "")
        {
            Console.WriteLine();
            Console.WriteLine("Вы нечего не ввели");
            Console.WriteLine();
        }
        if (b == true)
        {

            for (int i = 1; ; i++)
            {

                result = ferst + gerst;
                ferst = gerst;
                gerst = result;



                count++;
                if (result == c)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Число-{c} в последовательности Фибоначи находится на-{count} позиции");
                    Console.WriteLine();
                    break;
                }
                else if (result > c)
                {
                    Console.WriteLine();
                    Console.WriteLine($"В последовательности Фибоначи нет такого числа");
                    Console.WriteLine();
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Вы ввели не число");
            Console.WriteLine();
        }
    }
}
Fid();
