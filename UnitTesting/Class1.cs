using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2UnitTesting;


namespace UnitTesting
{
    public class Class1
    {
        [Test]
        [TestCase(5, 6, 22)]
        [TestCase(1, 1, 4)]
        [TestCase(999, 1999, 5996)]
        public void GetPerimeterMethodTest(int l, int w, int expected)
        {
            Assignment2UnitTesting.Rectangle _rect = new Assignment2UnitTesting.Rectangle(w, l);
            int result = _rect.CalculatePerimeter();
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(1, 20, 20)]
        [TestCase(30, 1, 30)]
        [TestCase(40, 40, 1600)]
        public void GetAreaMethodTest(int l, int w, int expected)
        {
            Assignment2UnitTesting.Rectangle _rect = new Assignment2UnitTesting.Rectangle(w, l);
            int result = _rect.CalculateArea();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetLength10Result10()
        {
            Assignment2UnitTesting.Rectangle _rect = new Assignment2UnitTesting.Rectangle(5, 10);
            int result = _rect.GetLength();
            Assert.AreEqual(10, result);
        }
        [Test]
        public void GetWidth5Result5()
        {
            Assignment2UnitTesting.Rectangle _rect = new Assignment2UnitTesting.Rectangle(5, 10);
            int result = _rect.GetWidth();
            Assert.AreEqual(5, result);
        }
        [Test]
        [TestCase(6, 6)]
        [TestCase(0, -1)]
        [TestCase(-40, -1)]
        public void SetLengthTest(int l, int expected)
        {
            Assignment2UnitTesting.Rectangle _rect = new Assignment2UnitTesting.Rectangle(5, 10);
            int result = _rect.SetLength(l);
            Assert.AreEqual(expected, result);
        }
        [Test]
        [TestCase(6, 6)]
        [TestCase(0, -1)]
        [TestCase(-40, -1)]
        public void SetWidthTest(int w, int expected)
        {
            Assignment2UnitTesting.Rectangle _rect = new Assignment2UnitTesting.Rectangle(5, 10);
            int result = _rect.SetWidth(w);
            Assert.AreEqual(expected, result);
        }
    }
}
