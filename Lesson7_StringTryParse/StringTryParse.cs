namespace Lesson7_StringTryParse;

class StringTryParse
{
    static void Main(string[] args)
    {
        string str = "5 прпрп";

        int a;
        
        bool result = int.TryParse(str, out a);

        if (result)
        {
            Console.WriteLine("Операция успешна, значение = " + a);
        }
        else
        {
            Console.WriteLine("Не удалось конвертировать!");
        }
    }
}