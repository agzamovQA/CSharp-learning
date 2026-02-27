using System.Globalization;

namespace Lesson18_CycleFor;

class Program
{
    static void Main(string[] args)
    {
        int limit = int.Parse(Console.ReadLine());

        // i - переменная, i < limit - условие. Выполняй ДО, i++ -- что выполнять(операция).
        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine(i);
        }
    }
}