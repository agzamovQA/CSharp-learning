using System.Globalization;

namespace Lesson14_LogicalOperations;

/*  Логические операторы
 *
 *  && - Сокращенное И
 *  || - Сокращенное ИЛИ
 *  &
 *  | - ИЛИ
 *  ! НЕ (Унарный)
 * 
 * 
 */

class InfectedOrNot
{
    static void Main(string[] args)
    {
        bool isInfected = true;
        bool isBrockenLeg = false;

        if (isInfected && isBrockenLeg)
        {
            Console.WriteLine("Вы заражены и у вас сломана нога!");
        }
        else
        {
            Console.WriteLine("Шансы есть, но сходите к врачу!");
        }
    }
}