using System.Globalization;

namespace HW1_ArithmeticMean;

class ArithmeticMean
{
    static void Main(string[] args)
    {
        NumberFormatInfo numberFormat = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        double a, b;
        
        Console.WriteLine("\nВычисленее среднего арифметического двух чисел \n");
        
        Console.WriteLine("\tВведите число 1:\n");
        while (!double.TryParse(Console.ReadLine(), numberFormat, out a))
        {
            Console.WriteLine("\tОшибка! Введите корректное число:");
        }
        
        Console.WriteLine("\tВведите число 2:");
        while (!double.TryParse(Console.ReadLine(), numberFormat, out b))
        {
            Console.WriteLine("\tОшибка! Введите корректное число:");
        }
        
        double result = (a + b) / 2;
        
        Console.WriteLine($"\tСреднее арифметическое чисел {a} и {b} = {result:F2}");
        
    }
}