namespace Tyuiu.VaganovMA.Sprint1.Task4.V10.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint1.Task4.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double a = 1;
        double wait = 2.175;
        var res = ds.Calculate(a);
        Assert.AreEqual(wait, res);
    }
}