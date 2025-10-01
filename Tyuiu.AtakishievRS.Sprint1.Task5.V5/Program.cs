using Tyuiu.AtakishievRS.Sprint1.Task5.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и классов Convert                            *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Присвоить целой переменной d первую цифру                               *");
        Console.WriteLine("* из дробной части положительного вещественного числа x.                  *"); 
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        double x, y;

        Console.WriteLine("Введите дробное число X:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Первая цифра дробной части числа = " + ds.Calculate(x));

        Console.ReadKey();
    }
}