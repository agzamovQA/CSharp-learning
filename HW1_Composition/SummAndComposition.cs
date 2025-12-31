using System.Globalization;

namespace HW1_Composition;

class SummAndComposition
{
    static void Main(string[] args)
    {
        NumberFormatInfo numberFormat = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        double a, b, c;
        
        Console.WriteLine("\nВычисленее суммы и произведения трех чисел \n");
        
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
        
        Console.WriteLine("\tВведите число 3:");
        while (!double.TryParse(Console.ReadLine(), numberFormat, out c))
        {
            Console.WriteLine("\tОшибка! Введите корректное число:");
        }
        
        double resultSumm = a + b + c;
        double resultComposition = a * b * c;
        
        Console.WriteLine($"\tСумма чисел {a} и {b} и {c} = {resultSumm:F2}");
        Console.WriteLine($"\tПроизведение чисел {a} и {b} и {c} = {resultComposition:F2}");
        
    }
}