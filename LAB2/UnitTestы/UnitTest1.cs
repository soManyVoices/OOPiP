using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ComplexLibrary.Tests
{
    [TestClass]
    public class ComplexNumberTests
    {
        [TestMethod]
        public void Addition_WithValidInputs_ReturnsCorrectResult()
        {
            // 
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);

            // 
            ComplexNumber result = c1 + c2;

            // 
            Assert.AreEqual(6, result.Real);
            Assert.AreEqual(8, result.Imaginary);
        }

        [TestMethod]
        public void Addition_WithValidInputs_ReturnsCorrectResult2()
        {
            // 
            ComplexNumber c1 = new ComplexNumber(-3, 3);
            ComplexNumber c2 = new ComplexNumber(4, -5);

            // 
            ComplexNumber result = c1 + c2;

            // 
            Assert.AreEqual(1, result.Real);
            Assert.AreEqual(-2, result.Imaginary);
        }

        [TestMethod]
        public void Addition_WithValidInputs_ReturnsCorrectResult3()
        {
            // 
            ComplexNumber c1 = new ComplexNumber(11, -11);
            ComplexNumber c2 = new ComplexNumber(11, 11);

            // 
            ComplexNumber result = c1 + c2;

            // 
            Assert.AreEqual(22, result.Real);
            Assert.AreEqual(0, result.Imaginary);
        }

        [TestMethod]
        public void Multiplication_WithValidInputs_ReturnsCorrectResult()
        {
            // 
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);

            // 
            ComplexNumber result = c1 * c2;

            // 
            Assert.AreEqual(-7, result.Real);
            Assert.AreEqual(22, result.Imaginary);
        }

        [TestMethod]
        public void Multiplication_WithValidInputs_ReturnsCorrectResult2()
        {
            // 
            ComplexNumber c1 = new ComplexNumber(2, -3);
            ComplexNumber c2 = new ComplexNumber(4, -5);

            // 
            ComplexNumber result = c1 * c2;

            // 
            Assert.AreEqual(-7, result.Real);
            Assert.AreEqual(-22, result.Imaginary);
        }

        [TestMethod]
        public void Multiplication_WithValidInputs_ReturnsCorrectResult3()
        {
            // 
            ComplexNumber c1 = new ComplexNumber(11, -11);
            ComplexNumber c2 = new ComplexNumber(11, 11);

            // 
            ComplexNumber result = c1 * c2;

            // 
            Assert.AreEqual(242, result.Real);
            Assert.AreEqual(0, result.Imaginary);
        }
    }
}