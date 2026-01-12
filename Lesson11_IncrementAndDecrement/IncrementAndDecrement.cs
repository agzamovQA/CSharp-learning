namespace Lesson11_IncrementAndDecrement;

class IncrementAndDecrement
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 0;

        a = a++; // постфиксный инкримент
        a = ++a; // префиксный инкримент

        b = b--; // постфиксный декримент
        b = --b; // префиксный декримент

        Console.WriteLine("Префиксный инкримент " + ++a);
        Console.WriteLine("Постфиксный инкримент " + b--);
    }
}