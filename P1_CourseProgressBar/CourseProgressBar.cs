using System.Globalization;

namespace P1_CourseProgressBar;

class CourseProgressBar
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(">>> COURSE PROGRESS BAR v0.0.3 \n    ---------------------------------------- \n");
            Console.WriteLine(":: Курсы доступные для выбора: \n    1 - C# SimpleCode\n    2 - QA Guru 'Java Automation'\n    3 - Kaino 3D (Witcher) \n    ---------------------------------------- \n");
            Console.WriteLine(":: Сервисные операции: \n    0 - Выход\n    ---------------------------------------- \n");
            Console.Write("Введите значение (0-3): ");

            string userInput = Console.ReadLine();
            int userChoice;
            double userLesson;
            double courseProgress;
            double lessonComplition;
        
            bool result = int.TryParse(userInput, out userChoice);

            if (result)
            {
                switch (userChoice)
                {
                    case 0: 
                        break;
                
                    case 1: 
                        Console.Write("Всего 110 уроков. Укажите ваш текущий урок: ");
                        while (!double.TryParse(Console.ReadLine(), out userLesson))
                        {
                            Console.WriteLine("\tОшибка! Введите корректное число:");
                        }

                        courseProgress = userLesson / 110 * 100;
                        courseProgress = Math.Round(courseProgress, 2);
                        lessonComplition = 110 - userLesson;

                        Console.WriteLine("\n    Вы прошли курс на " + courseProgress + "%");
                        Console.WriteLine("\n    Пройдено: " + userLesson + " из 110 уроков");
                        Console.WriteLine("\n    Осталось: " + lessonComplition + " уроков");
                        break;
                    
                    case 2: 
                        Console.Write("Всего 23 Основных урока. Укажите ваш текущий урок: ");
                        while (!double.TryParse(Console.ReadLine(), out userLesson))
                        {
                            Console.WriteLine("\tОшибка! Введите корректное число:");
                        }

                        courseProgress = userLesson / 23 * 100;
                        courseProgress = Math.Round(courseProgress, 2);
                        lessonComplition = 23 - userLesson;

                        Console.WriteLine("\n    Вы прошли курс на " + courseProgress + "%");
                        Console.WriteLine("\n    Пройдено: " + userLesson + " из 23 уроков");
                        Console.WriteLine("\n    Осталось: " + lessonComplition + " уроков");
                        break;
                }
            
            }
            else
            {
                Console.WriteLine("Что-то пошло не так. Выбирите подходящий курс");
            }
        
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        
    }
}