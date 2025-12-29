namespace Lesson8_ArithmeticOperations;

class ArithmeticOperations
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 3;  
        
        int resultSumm = a + b;
        Console.WriteLine("Результат сложения: " + resultSumm);
        
        int resultSubtraction = a - b;
        Console.WriteLine("Результат вычитания: " + resultSubtraction);       
        
        int resultMultiplication = a * b;
        Console.WriteLine("Результат умножения: " + resultMultiplication);
        
        int resultDivision = a / b;
        Console.WriteLine("Результат деления: " + resultDivision);
        
        int resultDivisionRemainder = a % b;
        Console.WriteLine("Результатом деления является остаток: " + resultDivisionRemainder);
        
    }
}