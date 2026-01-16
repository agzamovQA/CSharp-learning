using System.Globalization;

namespace Lesson15_SwitchOn;

class SwitchEnum
{
    static void Mai(string[] args)
    {
        ConsoleKey consoleKey = Console.ReadKey().Key;

        switch (consoleKey)
        {
            // Alt + Enter -- "Generate switch cases"
            case ConsoleKey.D0:
                Console.WriteLine("Введена цифра 0");
                break;
            case ConsoleKey.D1:
                Console.WriteLine("Введена цифра 1");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("Введена цифра 2");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("Введена цифра 3");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}