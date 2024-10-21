namespace Tyuiu.VaganovMA.Sprint1.Task4.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task4V10
{
    public double Calculate(double a)
    {
        var c = (1 + (Math.Cos(a)));
        var b = (Math.Pow((Math.Sin(a)),2));
        var res =(Math.Round((c/b),3));
        return res;
    }
}

