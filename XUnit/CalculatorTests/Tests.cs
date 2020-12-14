
using NUnit.Framework;
using XUnit;
namespace CalculatorTests
{
    [TestFixture]
    public class Tests
    {
        Calculator calculator = new Calculator();
        static readonly object[] divideCases =
        {
            new object[] { 12, 3, 4 },
            new object[] { 9999999, 3, 3333333 },
            new object[] { 1, 1, 1 }
        };

        static readonly object[] modCases =
        {
            new object[] { 12, 5, 2 },
            new object[] { 9999999, 4, 3 },
            new object[] { 100, 2, 0 }
        };

        static readonly object[] sumCases =
        {
            new object[] { 0, 0, 0 },
            new object[] { -10000, 10000, 0 },
            new object[] { 999.999, 111.111, 1111.110}
        };

        static readonly object[] diffCases =
        {
            new object[] { 12, 3, 9 },
            new object[] { 9999999, 3333333, 6666666 },
            new object[] { 1, 1, 0 }
        };

        static readonly object[] multiplyCases =
        {
            new object[] { 12, 3, 36 },
            new object[] { 100.1, 0, 0 },
            new object[] { -1.1, -1, 1.1 }
        };

        static readonly object[] powCases =
        {
            new object[] { 2, 3, 8 },
            new object[] { 99999, 0, 1 },
            new object[] { 1, 1000000, 1 },
            new object[] { 5, 100, 7, 888609052210118E+69}
        };

        [Test, TestCaseSource("divideCases")]
        public void DivTest(double firstValue, double secondValue, double result)
        {
            Assert.AreEqual(result, calculator.culcFunctions[5].Invoke(firstValue, secondValue), 0.001);
        }

        [Test, TestCaseSource("modCases")]
        public void ModTest(double firstValue, double secondValue, double result)
        {
            Assert.AreEqual(result, calculator.culcFunctions[4].Invoke(firstValue, secondValue), 0.001);
        }

        [Test]
        public void DivByZeroExceprionTest()
        {
            Assert.Catch<System.DivideByZeroException>(() => calculator.culcFunctions[5].Invoke(9999, 0));
        }

        [Test]
        public void ModByZeroExceprionTest()
        {
            Assert.Catch<System.DivideByZeroException>(() => calculator.culcFunctions[4].Invoke(9999, 0));
        }

        [Test, TestCaseSource("sumCases")]
        public void SumTest(double firstValue, double secondValue, double result)
        {
            Assert.AreEqual(result, calculator.culcFunctions[1].Invoke(firstValue, secondValue), 0.001);
        }

        [Test, TestCaseSource("diffCases")]
        public void DiffTest(double firstValue, double secondValue, double result)
        {
            Assert.AreEqual(result, calculator.culcFunctions[2].Invoke(firstValue, secondValue), 0.001);
        }

        [Test, TestCaseSource("multiplyCases")]
        public void MultiplyTest(double firstValue, double secondValue, double result)
        {
            Assert.AreEqual(result, calculator.culcFunctions[3].Invoke(firstValue, secondValue), 0.001);
        }



    }
}