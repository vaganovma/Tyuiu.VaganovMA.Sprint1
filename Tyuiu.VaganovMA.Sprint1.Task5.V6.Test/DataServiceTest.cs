namespace Tyuiu.VaganovMA.Sprint1.Task5.V6.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint1.Task5.V6.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        int a = 143;
        double wait = 3;
        var res = ds.Calculate(a);
        Assert.AreEqual(wait, res);
    }
}