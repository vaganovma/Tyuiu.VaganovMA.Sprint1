namespace Tyuiu.VaganovMA.Sprint1.Task7.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task7V10
{
    public double Calculate(double x)
    {
        var c = 2 * (1 / (Math.Tan(3 * x)));
        var v = (Math.Log((Math.Cos(x))));
        var m = 1 + (Math.Pow(x, 2));
        var n = (Math.Log(m));
        var a = (v / n);
        var res = (Math.Round((c - a), 3));
        return res;
    }
}

