namespace Lesson6_StringConverter;

class StringConverter
{
    static void Main(string[] args)
    {
        string userInput;

        int a, b;

        Console.WriteLine("Введите число 1");
        
        userInput = Console.ReadLine();
        
        a = Convert.ToInt32(userInput);

        Console.WriteLine("Введите число 2");
        
        userInput = Console.ReadLine();
        
        b = Convert.ToInt32(userInput);

        int result = a + b;
        
        Console.WriteLine("Результат сложения" + result);

    }
}