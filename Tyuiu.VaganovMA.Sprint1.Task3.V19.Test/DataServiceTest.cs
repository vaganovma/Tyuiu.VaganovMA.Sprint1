namespace Tyuiu.VaganovMA.Sprint1.Task3.V19.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint1.Task3.V19.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double x1 = 2;
        double y1 = 2;
        double x2 = 3;
        double y2 = 3;
        double wait = 1;
        var res = ds.ElephCanMove(x,y);
        Assert.AreEqual(wait, res);
    }
}