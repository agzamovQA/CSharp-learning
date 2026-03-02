using System.Globalization;

namespace Lesson19_CycleForReverse;

/* Цикл for 
 * Используем сразу 2 переменных, 2 условия, 2 действия
 * Используем цикл в правильном и орбатном порядках. Пример с переменной z
 */

class Program
{
    static void Main(string[] args)
    {
        int limit = int.Parse(Console.ReadLine());
        
        for (int i = 0, j = 10; i < limit && j < 20; i++, j++)
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
            break;
        }
        // Обычный порядок
        for (int z = 0; z < 10; z++)
        {
            Console.WriteLine(z);
        }
        
        // Обратный порядок
        for (int z = 10; z > 0; z--)
        {
            Console.WriteLine(z);
        }
        
        //todo Узнать, как перебирать массив в обратном порядке
        
    }
}