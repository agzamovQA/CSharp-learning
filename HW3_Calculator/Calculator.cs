using System.Globalization;

namespace HW3_Calculator;

class Calculator
{
    static void Main(string[] args)
    {
        double userNumeric1, userNumeric2;
        double result;
        
        Console.WriteLine("Добро пожаловать в Калькулятор. \nВыберите одну из операций (работаем только с 2-мя числами): \t\n 0 - Сложение, вычитание, умножение, деление. \t\n 1 - Вычисление среднего арифметического. \t\n 2 - Чет/нечет\n");
        
        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        { 
            case 0: 
                
                NumberFormatInfo numberFormat = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
                
                Console.WriteLine("\t>>Сложение, вычитание, умножение, деление.");
            
                Console.WriteLine("\tВведите Число 1:");
            
                while (!double.TryParse(Console.ReadLine(), numberFormat, out userNumeric1))
                {
                    Console.WriteLine("\tОшибка! Введите корректное число:");
                } 
                
                Console.WriteLine("\tВведите Число 2:");
            
                while (!double.TryParse(Console.ReadLine(), numberFormat, out userNumeric2))
                {
                    Console.WriteLine("\tОшибка! Введите корректное число:");
                }
                
                Console.WriteLine("\tВыберите операцию: '+', '-', '*', '/'");
                string calculation = Console.ReadLine();

                    switch (calculation)
                    {
                    case "+":
                        result = userNumeric1 + userNumeric2;
                        Console.WriteLine("Результат сложения: " + userNumeric1 + " + " + userNumeric2 + " = " + result);
                        
                        break;
                    
                    case "-":
                        result = userNumeric1 - userNumeric2;
                        Console.WriteLine("Результат вычитания: " + userNumeric1 + " - " + userNumeric2 + " = " + result);
                        
                        break;
                    
                    case "*":
                        result = userNumeric1 * userNumeric2;
                        Console.WriteLine("Результат умножения: " + userNumeric1 + " * " + userNumeric2 + " = " + result);
                        
                        break;
                    
                    case "/":
                        if (userNumeric2 != 0) // Проверка деления на ноль
                        {
                            result = userNumeric1 / userNumeric2;
                            Console.WriteLine("Результат деления: " + userNumeric1 + " / " + userNumeric2 + " = " + result);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: на ноль делить НЕЛЬЗЯ .!.");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция!");
                        break;
                    }
                
                    break;
            
            case 1:
                
                NumberFormatInfo numberFormat1 = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
        
                Console.WriteLine("\n>>Вычисленее среднего арифметического двух чисел");
        
                Console.WriteLine("\tВведите число 1:");
                while (!double.TryParse(Console.ReadLine(), numberFormat1, out userNumeric1))
                {
                    Console.WriteLine("\tОшибка! Введите корректное число:");
                }
        
                Console.WriteLine("\tВведите число 2:");
                while (!double.TryParse(Console.ReadLine(), numberFormat1, out userNumeric2))
                {
                    Console.WriteLine("\tОшибка! Введите корректное число:");
                }
        
                result = (userNumeric1 + userNumeric2) / 2;
        
                Console.WriteLine("\tСреднее арифметическое чисел " + userNumeric1 + " и " + userNumeric2 + " = " + result);
                
                break;
        }
    }
}