using System.Globalization;

namespace HW3_Calculator;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в Кальулятор. Выберите одну из операций: \t\n 0 - Сложение, вычитание, деление. \t\n 1 - Вычисление среднего арифметического. \t\n 2 - Чет/нечет\n");
        
        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        { 
            case 0: 
                double userNumeric1, userNumeric2;
                double resultAddition;
                
                NumberFormatInfo numberFormat = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
                
                Console.WriteLine("\tВы выбрали Сложение, вычитание, деление.");
            
                Console.WriteLine("\tВведите Число 1.");
            
                while (!double.TryParse(Console.ReadLine(), numberFormat, out userNumeric1))
                {
                    Console.WriteLine("\tОшибка! Введите корректное число:");
                } 
                
                Console.WriteLine("\tВведите Число 2.");
            
                while (!double.TryParse(Console.ReadLine(), numberFormat, out userNumeric2))
                {
                    Console.WriteLine("\tОшибка! Введите корректное число:");
                }
                
                Console.WriteLine("\tВыберите операцию: '+', '-', '*', '/'");
                string calculation = Console.ReadLine();

                    switch (calculation)
                    {
                    case "+":
                        resultAddition = userNumeric1 + userNumeric2;
                        Console.WriteLine("Результат сложения: " + userNumeric1 + " + " + userNumeric2 + " = " + resultAddition);
                        
                        break;
                    }
                
                    break;
        }
    }
}