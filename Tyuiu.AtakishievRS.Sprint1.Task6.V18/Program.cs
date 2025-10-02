using Tyuiu.AtakishievRS.Sprint1.Task6.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класса String                                  *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить,               *");
        Console.WriteLine("* что строка является символьным представлением натурального числа.       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите текст: ");
        string x = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool res = ds.CheckNumber(x);
        if (res == true)
        {
            Console.WriteLine("Ваша строка натуральное число");
        }
        else 
        {
            Console.WriteLine("Ваша строка не является натуральным числом");
        }

        Console.ReadKey();
    }
}