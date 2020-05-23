using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UITestCalculator
{
   
    public class TestClass
    {
        MainScreenModel _msModel = new MainScreenModel();
        [SetUp]

        public void StarAppBeforeEachTest()
        {
            AppInitializer.StartApp();
        }
        [Test]
        public void MyFirstMobileTest()
        {
            //AppInitializer.App.Repl();
            _msModel.TapOnOne()
                .TapOnPlus()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
        }
        [Test]
        public void TestSubtractLargerNumberFromSmallerNumber()
        {
            _msModel.TapOnTwo()
                .TapOnThree()
                .TapOnMinus()
                .TapOnFour()
                .TapOnFive()
                .TapOnEqual();
            Assert.AreEqual("-22", _msModel.GetTextFromTextField());
        }
        [Test]
        public void TestAddThreeNumbers()
        {
            _msModel.TapOnEight()
                .TapOnNine()
                .TapOnPlus()
                .TapOnOne()
                .TapOnTwo()
                .TapOnThree()
                .TapOnPlus()
                .TapOnFour()
                .TapOnFive()
                .TapOnSix()
                .TapOnEqual();
            Assert.AreEqual("668", _msModel.GetTextFromTextField());
        }

        [Test]
        public void TestMultiplyTwoNumbers()
        {
            _msModel.TapOnOne()
                .TapOnTwo()
                .TapOnMult()
                .TapOnThree()
                .TapOnFour()
                .TapOnFive()
                .TapOnEqual();
            Assert.AreEqual("4140", _msModel.GetTextFromTextField());
        }

        [Test]
        public void TestMultiplyThreeNumbers()
        {
            _msModel.TapOnOne()
                .TapOnTwo()
                .TapOnMult()
                .TapOnThree()
                .TapOnFour()
                .TapOnFive()
                .TapOnMult()
                .TapOnSix()
                .TapOnSeven()
                .TapOnEight()
                .TapOnNine()
                .TapOnEqual();
                
            Assert.AreEqual("28106460", _msModel.GetTextFromTextField());
        }
        [Test]
        public void TestSumAndMultiplyNumbers()
        {
            _msModel.TapOnEight()
                .TapOnThree()
                .TapOnFour()
                .TapOnFive()
                .TapOnPlus()
                .TapOnOne()
                .TapOnFive()
                .TapOnSix()
                .TapOnMult()
                .TapOnNine()
                .TapOnSeven()
                .TapOnTwo()
                .TapOnEqual();

            Assert.AreEqual("8262972", _msModel.GetTextFromTextField());
        }
        [Test]
        public void TestFractionalSummation()
        {
            _msModel.TapOnOne()
                .TapOnTwo()
                .TapOnDot()
                .TapOnThree()
                .TapOnPlus()
                .TapOnOne()
                .TapOnDot()
                .TapOnTwo()
                .TapOnThree()
                .TapOnEqual();

            Assert.AreEqual("13.53", _msModel.GetTextFromTextField());
        }

        [Test]
        public void TestFractionalNumberMultiplication()
        {
            _msModel.TapOnNine()
                .TapOnNine()
                .TapOnDot()
                .TapOnFive()
                .TapOnTwo()
                .TapOnMult()
                .TapOnOne()
                .TapOnEight()
                .TapOnEqual();

            Assert.AreEqual("1791.36", _msModel.GetTextFromTextField());
        }

        [Test]
        public void TestSubtractionFractionalNumbers()
        {
            _msModel.TapOnNine()
                .TapOnNine()
                .TapOnDot()
                .TapOnFive()
                .TapOnTwo()
                .TapOnMinus()
                .TapOnOne()
                .TapOnEight()
                .TapOnZero()
                .TapOnDot()
                .TapOnFive()
                .TapOnEqual();

            Assert.AreEqual("-80.98", _msModel.GetTextFromTextField());
        }

        [Test]
        public void TestFractionalDivision()
        {
            _msModel.TapOnEight()
                .TapOnZero()
                .TapOnDot()
                .TapOnFive()
                .TapOnDiv()
                .TapOnTwo()
                .TapOnEqual();

            Assert.AreEqual("40.25", _msModel.GetTextFromTextField());
        }

        [Test]
        public void TestDivisionByZero()
        {
            _msModel.TapOnEight()
                .TapOnDiv()
                .TapOnZero()
                .TapOnEqual();

            Assert.AreEqual("Infinity", _msModel.GetTextFromTextField());
        }

        [Test]
        public void TestSummingNegativeNumbers()
        {
            _msModel.TapOnEight()
                .TapOnFive()
                .TapOnPlus()
                .TapOnOne()
                .TapOnZero()
                .TapOnEqual();

            Assert.AreEqual("-75", _msModel.GetTextFromTextField());
        }
    }
}
