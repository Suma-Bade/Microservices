using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class TestCalculate
    {
        calculate obj = null;
        [SetUp]
        public void Setup()
        {
            obj = new calculate();
        }

        [Test]
        public void TestAdd()
        {
            int actual = obj.Add(3, 5);
            int expected = 8;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        [Description("Test greet method")]
        public void GreetTest()
        {
            string result = obj.Greet("Sachin");
            Assert.NotNull(result);
            Assert.AreEqual("Hello Sachin", result);
        }
    }
}