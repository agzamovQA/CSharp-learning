
/*
    == Равно
    != Не равно
    > Больше
    < Меньше
    >= Больше или равно
    <= Меньше или равно
 */


namespace Lesson12_ComparisonOperators;

class ComparisonOperators
{
    static void Main(string[] args)
    {
        int firstValue = 5;
        int secondValue = 10;
        
        
        Console.WriteLine("Число 5 равно числу 10: " + (firstValue == secondValue));
        Console.WriteLine("Число 5 Не равно числу 10: " + (firstValue != secondValue));
        Console.WriteLine("Число 5 больше числа 10: " + (firstValue > secondValue));
        Console.WriteLine("Число 5 меньше числа 10: " + (firstValue < secondValue));
        Console.WriteLine("Число 5 больше или равно числу 10: " + (firstValue >= secondValue));
        Console.WriteLine("Число 5 меньше или равно числу 10: " + (firstValue <= secondValue));
    }
}