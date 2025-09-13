using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BubenkoLG.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Людмила";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Людмила", res);
        }
    }
}
