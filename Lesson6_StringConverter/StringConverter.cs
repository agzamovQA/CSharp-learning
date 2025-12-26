using System.Globalization;

namespace Lesson6_StringConverter;

class StringConverter
{
    static void Main(string[] args)
    {
        NumberFormatInfo numberFormat = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };
            
        string userInput;

        int a;
        double b;

        Console.WriteLine("Введите число 1");
        
        userInput = Console.ReadLine();
        
        a = Convert.ToInt32(userInput);

        Console.WriteLine("Введите число 2");
        
        userInput = Console.ReadLine();
        
        b = Convert.ToDouble(userInput, numberFormat);

        double result = a + b;
        
        Console.WriteLine("Результат сложения = " + result);

    }
}