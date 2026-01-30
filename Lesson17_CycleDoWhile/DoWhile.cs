namespace Lesson17_CycleDoWhile;

class DoWhile
{
    static void Main(string[] args)
    {

        while (false) // Сначала проверяет условие, а потом исполняет код. Цикл не будет выполнятся, если неподходит условие
        {
            Console.WriteLine("Цикл While выполнился!");
        }


        do // Сначала исполняет код, а затем проверяет условие. Цикл исполнится хотя бы 1 раз.
        {
            Console.WriteLine("Цикл Do While выполнился!");
        } while (false);

        int count = 0;
        
        do // Сначала исполняет код, а затем проверяет условие. Цикл исполнится хотя бы 1 раз.
        {
            count++;
            Console.WriteLine(count);
        } while (count < 5);
    }
}