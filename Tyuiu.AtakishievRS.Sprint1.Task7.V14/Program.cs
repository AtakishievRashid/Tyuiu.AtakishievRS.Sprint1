using Tyuiu.AtakishievRS.Sprint1.Task7.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("*               2                                                         *");
        Console.WriteLine("*      -x  5*(x)         2                                                *");
        Console.WriteLine("* z = 2  + ------ - cos(x) + sin(2*x*y)                                   *");
        Console.WriteLine("*               3                                                         *");
        Console.WriteLine("*          3*(x)                                                          *");

        Console.WriteLine("*                                                                         *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        double x, y;

        Console.WriteLine("Введите число X:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число Y:");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadKey();

    }
}