using NUnit.Framework;
using OperatingSystems;
using Assert = NUnit.Framework.Assert;

namespace OperatingSystemTests
{
    [TestFixture]
    class FactoryTests
    {
        [SetUp]
        public void SetUp()
        {
            _factory = new Factory();

        }

        [TearDown]
        public void TestTearDown()
        {
            _factory = null;

        }

        #region Tests

        [TestCase("ANDROID", Messages.Android)]
        [TestCase("IOS", Messages.Ios)]
        [TestCase("WINDOWS", Messages.Windows)]
        public void GetOperatingSystem_UpperCaseInput_ExpectedOpTest(string type, string expectedOp)
        {
            AssertPositiveCaseTestResult(type, expectedOp);

        }

        [TestCase("AnDROiD", Messages.Android)]
        [TestCase("Ios", Messages.Ios)]
        [TestCase("WiNDoWS", Messages.Windows)]
        public void GetOperatingSystem_MixedCaseInput_ExpectedOpTest(string type, string expectedOp)
        {
            AssertPositiveCaseTestResult(type, expectedOp);
        }

        [TestCase("WIN", "")]
        public void GetOperatingSystemNegativeTest(string type, string expectedOp)
        {
            var op = _factory.GetOperatingSystem(type);
            Assert.IsNull(op);
        }

        #endregion


        #region private methods

        private void AssertPositiveCaseTestResult(string type, string expectedOp)
        {
            var op = _factory.GetOperatingSystem(type);
            Assert.IsNotNull(op);
            Assert.That(op.Message.Equals(expectedOp));
        }

        #endregion

        #region private members

        private IFactory _factory; 

        #endregion

    }
}
