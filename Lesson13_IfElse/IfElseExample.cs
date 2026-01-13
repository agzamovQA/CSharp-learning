namespace Lesson13_IfElse;

class IfElseExample
{
    static void Main(string[] args)
    {
        int userValue;
        
        userValue = int.Parse(Console.ReadLine());

        if (userValue == 5)
        {
            Console.WriteLine("Ваше значение равно 5");
        }
        else
        {
            Console.WriteLine("Ваше значение НЕ равно 5");
        }

    }
}