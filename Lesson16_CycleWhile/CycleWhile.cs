namespace Lesson16_CycleWhile;

    /*
     * Цикл while
     */

class CycleWhile
{
    static void Main(string[] args)
    {
        int countOperations = 0; // Просто интовая переменная для подсчета кол-ва выполнения цикла
        int limitOperations = int.Parse(Console.ReadLine()); // Переменная для выставления лимита по операциям с циклом
        while (countOperations < limitOperations) // В круглых скобочках - Условие до каких пор будет выполняться цикл.
        {
            countOperations++;
            Console.WriteLine(countOperations);
        }
    }
}