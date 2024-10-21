namespace Tyuiu.VaganovMA.Sprint1.Task3.V19;

using Tyuiu.VaganovMA.Sprint1.Task3.V19.Lib;

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
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #19 " +
            "Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.\r\n\r\nРасчеты:\r\n\r\n \r\n\r\nНаписать программу, которая печатает true или false в зависимости от того, может ли шахматная фигура «Слон» с одного заданного поля шахматной доски перейти за один ход на другое. Пользователь задаёт координаты двух ячеек шахматной доски (x1 и y1, x2 и y2, каждое в диапазоне от 1 до 8).                                                            *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        double x1;
        double x2;
        double y1;
        double y2;

        x1 = Convert.ToDouble(Console.ReadLine());
        x2 = Convert.ToDouble(Console.ReadLine());
        y1 = Convert.ToDouble(Console.ReadLine());
        y2 = Convert.ToDouble(Console.ReadLine());


        {
            if (((Math.Abs(x1 - x2) == (Math.Abs(y1 - y2)));
              {
            Console.WriteLine("true");
              }
        else
              {
            Console.WriteLine("false");
              }
        }

        Console.ReadKey();


    }
}
