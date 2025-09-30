using System.Numerics;
using Tyuiu.AtakishievRS.Sprint1.Task3.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите вещественное число: ");
        double number = Convert.ToDouble(Console.ReadLine());

        bool result = ds.ZeroCheck(number);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (result)
        {
            Console.WriteLine("Среди первых трёх цифр дробной части есть 0.");
        }
        else
        {
            Console.WriteLine("Среди первых трёх цифр дробной части нет 0.");
        }

        

        Console.ReadLine();
    }
}