using System.Globalization;

namespace Lesson15_SwitchOn;

class SwitchOn
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите роль для работы: \n Agzamurai - Администратор \n tempUser - Временный пользователь \n");
        
        string userName = Console.ReadLine();

        switch (userName)
        {
            case "Agzamurai":
                Console.WriteLine("\tВыбрана роль администратора");
                bool admin = true;
                
                if (admin)
                {
                    Console.WriteLine("\t \tВведите пароль Администратора: ");
                    int userPassword = int.Parse(Console.ReadLine());

                    switch (userPassword)
                    {
                        case 1234: 
                            Console.WriteLine("\t \t \tПароль принят! ");
                            break;
                        default:
                            Console.WriteLine("Проверьте имя пользователя или пароль");
                            break;
                    }
                }
                break;    
            
            case "tempUser":
                Console.WriteLine("Вы выбрали роль пользователя");
                bool user = true;
                
                if (user)
                {
                    Console.WriteLine("\t \t Введите пароль пользователя: ");
                    int userPassword = int.Parse(Console.ReadLine());

                    switch (userPassword)
                    {
                        case 4321: 
                            Console.WriteLine("\t \t \t Пароль принят!");
                            break;
                        default:
                            Console.WriteLine("Проверьте имя пользователя или пароль");
                            break;
                    }
                }
                break; 
            
            default:
                Console.WriteLine("Такого пользователя не существует.!.");
                break;
        }
    }
}