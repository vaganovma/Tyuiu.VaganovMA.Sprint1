namespace Tyuiu.VaganovMA.Sprint1.Task5.V6;

using Tyuiu.VaganovMA.Sprint1.Task5.V6.Lib;

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
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                            *");
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич | ИИПБ-24-2                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int k;

        Console.WriteLine("введите количество дней от 1 до 365 (a)");
        k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        int R = ds.Calculate(k);
        
        Console.WriteLine("Ответ = " + (R));
        switch (R)
        { 
            case 1:
            Console.WriteLine("Понедельник ");
            break;
            case 2: 
            Console.WriteLine("Вторник ");
            break;
            case 3: 
            Console.WriteLine("Среда ");
            break;
            case 4:
            Console.WriteLine("Четверг ");
            break;
            case 5:
            Console.WriteLine("Пятница ");
            break;
            case 6:
            Console.WriteLine("Суббота ");
            break;
            case 7:
            Console.WriteLine("Воскресенье ");
            break;
        }    
            
        Console.ReadKey();


    }
}
