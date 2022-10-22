using System.Runtime.ExceptionServices;

Console.WriteLine("Введите текст");
string a = Console.ReadLine();
bool b = int.TryParse(a, out int c);
int ferst = 0;
int count = 0;
int result = 0;
void Fid()
{
    for (int i = 1; ; i++)
    {

        result += ferst + i;
        ferst = i;

        count++;
        if (result == c)
        {
            break;
        }
        else if (result > c)
        {
            Console.WriteLine($"В последовательности Фибоначи нет такого числа");
            Console.WriteLine();
            break;
        }

    }
    Console.WriteLine($"{count}");
}
Fid();
