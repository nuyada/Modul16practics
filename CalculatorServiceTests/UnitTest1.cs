using Modul16practics;

namespace CalculatorServiceTests
{
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }
        /// <summary>
        /// Тест для суммы 2 чисел
        /// </summary>
        [Test]
        public void Additional_ShouldReturnCorrectSum()
        {
            Assert.That(calculator.Additional(4, 5) == 9);
        }
        /// <summary>
        /// Тест на вычитание 2 чисел
        /// </summary>
        [Test]
        public void Subtraction_ShouldReturnCorrectDifference()
        {
            Assert.That(calculator.Subtraction(10, 5) == 5);
        }
        /// <summary>
        /// Тест на умножение 2 чисел
        /// </summary>
        [Test]
        public void Miltiplication_ShouldReturnCorrectProduct()
        {
            Assert.That(calculator.Miltiplication(10, 5) == 50);
        }
        /// <summary>
        /// Тест на деление 2 чисел
        /// </summary>
        [Test]
        public void Division_ShouldReturnCorrectQuotient()
        {
            Assert.That(calculator.Division(10, 5) == 2);
        }
    }
}