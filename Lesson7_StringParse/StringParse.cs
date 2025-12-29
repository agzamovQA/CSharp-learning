namespace Lesson7_StringParse;

class StringParse
{
    static void Main(string[] args)
    {
        string str = "5 abcd";

        try
        {
            int a = int.Parse(str);
            Console.WriteLine("Успешная конвертация = " + a);
        }
        catch (Exception)

        {
            Console.WriteLine("Ошибка при конвертации");
        }
    }
}