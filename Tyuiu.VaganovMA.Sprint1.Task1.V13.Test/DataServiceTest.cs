
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint1.Task1.V13.Lib;

namespace Tyuiu.VaganovMA.Sprint1.Task1.V13.Test;

    [TestClass]
    public class DataServiceTest
    {
           [TestMethod]
            public void ValidExpression()
     {
        DataService ds = new DataService();
        double x = 2;
        var res = ds.Calculate(x);
        Assert.AreEqual(2, res);
      }
    }
