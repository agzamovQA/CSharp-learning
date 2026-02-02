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

        int evenNumberSumm = 0;
        int oddNumberSumm = 0;

        while (lowestNumber < highestNumber)
        {
            if (++lowestNumber % 2 == 0) //Использован префиксный инкремент, чтобы сначала прибавлял, а потом делил на 2
            {
                even++;
                evenNumberSumm += lowestNumber; // Пример сокращенной арифметической формы
                Console.WriteLine(lowestNumber + " - четное число");
            }
            else
            {
                odd++;
                oddNumberSumm = oddNumberSumm + lowestNumber;
                Console.WriteLine(lowestNumber + " - нечетное число");
            }
        }
        
        Console.WriteLine("\nИтоги для диапазона от " + originalLowestNumber + " до " + originalHighestNumber);
        Console.WriteLine("Всего четных: " + even);
        Console.WriteLine("Всего нечетных: " + odd);        
        Console.WriteLine("Сумма четных: " + evenNumberSumm);
        Console.WriteLine("Сумма нечетных: " + oddNumberSumm);
        
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
