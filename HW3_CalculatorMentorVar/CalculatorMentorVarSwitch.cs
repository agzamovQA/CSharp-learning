using System.Globalization;

namespace HW3_CalculatorMentorVar;

class CalculatorMentorVarSwitch
{
    static void Main(string[] args)
    {
        while (true) // Нужен для повторного запуска программы без повторного открытия.
        {
            Console.Clear(); //Очищаем консоль перед повторным запуском.
            double firstValue, secondValue;
            string action;

            try //Попробуй ввести цифры, если не цифры то выдай ошибку.
            {
                Console.WriteLine("Введите число 1:");
                firstValue = double.Parse(Console.ReadLine());        
        
                Console.WriteLine("Введите число 2:");
                secondValue = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка преобразования строки в число");
                Console.ReadLine();
                continue; //Вернуться к началу цикла
            }

            Console.WriteLine("Выберите операцию: '+', '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
            
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;            
            
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;            
            
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка преобразования Строки в число");
                    break;
            }
            Console.ReadLine();
        }
    }
}