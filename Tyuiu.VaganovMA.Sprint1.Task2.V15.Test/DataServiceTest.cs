namespace Tyuiu.VaganovMA.Sprint1.Task2.V15.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint1.Task2.V15.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        int x = 2;
        var res = ds.CalculateCubeVolume(x);
        Assert.AreEqual(8, res);
    }
}