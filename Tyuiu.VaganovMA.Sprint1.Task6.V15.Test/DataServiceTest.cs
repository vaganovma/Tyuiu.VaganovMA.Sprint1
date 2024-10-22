namespace Tyuiu.VaganovMA.Sprint1.Task6.V15.Test;
using System.Diagnostics.Tracing;

using Tyuiu.VaganovMA.Sprint1.Task6.V15.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCheckLettersCount()
    {
        DataService ds = new DataService();
        string value = "Мне не нравится когда в расписании одна физра!";
        bool res = ds.CheckLettersCount(value);
        Assert.AreEqual(true, res);
    }
} 