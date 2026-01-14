namespace HW2_EvenOdd;

class EvenOddNumber
{
    static void Main(string[] args)
    {
        int userValue;

        Console.WriteLine("Введите число, для определения четности: \n");
        
        userValue = int.Parse(Console.ReadLine());

        if (userValue % 2 == 0)
        {
            Console.WriteLine("Вы ввели четное число");
        }
        else
        {
            Console.WriteLine("Вы ввели нечетное число");
        }

    }
}