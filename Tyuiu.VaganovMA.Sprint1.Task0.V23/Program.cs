using Tyuiu.VaganovMA.Sprint1.Task0.V23.Lib;

namespace Tyuiu.VaganovMA.Sprint1.Task0.V23;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Ваганов М А | ИИПБ-24-2";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые                                                           *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*         10 / (2+3)                                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate());

        Console.ReadKey();


    }
}
