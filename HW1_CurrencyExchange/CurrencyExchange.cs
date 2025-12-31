using System.Globalization;

namespace HW1_CurrencyExchange;

class CurrencyExchange
{
    static void Main(string[] args)
    {
        NumberFormatInfo numberFormat = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        double a, b;
        b = 79.87;
        
        Console.WriteLine("\nДобро пожаловать в обмен валют. \nМы умеем менять только $ на Рубли");
        Console.WriteLine("\nТекущий курс: 79.87 за 1$  \n");
        
        Console.WriteLine("Введите количество $, которые хотите обменять:\n");
        while (!double.TryParse(Console.ReadLine(), numberFormat, out a))
        {
            Console.WriteLine("\tОшибка! Введите корректное число:");
        }
        
        
        double resultSumm = a * b;
        
        Console.WriteLine($"Вы получите {resultSumm:F2} Рублей");
    }
}