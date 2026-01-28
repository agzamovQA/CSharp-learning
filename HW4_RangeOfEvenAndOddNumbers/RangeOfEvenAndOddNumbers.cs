namespace HW4_RangeOfEvenAndOddNumbers;

class RangeOfEvenAndOddNumbers
{
    static void Main(string[] args)
    {
        int even =0, odd =0;
        
        Console.Write("Введите число с которого начать подсчет: ");
        int lowestNumber = int.Parse(Console.ReadLine());
        
        Console.Write("Введите число на котором закончить подсчет: ");
        int highestNumber = int.Parse(Console.ReadLine());
        
        int originalLowestNumber = lowestNumber; 
        int originalHighestNumber = highestNumber;

        while (lowestNumber < highestNumber)
        {
            if (++lowestNumber % 2 == 0) //Использован префиксный инкремент, чтобы сначала прибавлял, а потом делил на 2
            {
                even++;
                Console.WriteLine(lowestNumber + " - четное число");
            }
            else
            {
                odd++;
                Console.WriteLine(lowestNumber + " - нечетное число");
            }
        }
        
        Console.WriteLine("\nИтоги для диапазона от " + originalLowestNumber + " до " + originalHighestNumber);
        Console.WriteLine("Всего четных: " + even);
        Console.WriteLine("Всего нечетных: " + odd);
        
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
