namespace Tyuiu.VaganovMA.Sprint1.Task7.V10.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint1.Task7.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double x = 1;
        double wait = -13.142;
        var res = ds.Calculate(x);
        Assert.AreEqual(wait, res);
    }
}