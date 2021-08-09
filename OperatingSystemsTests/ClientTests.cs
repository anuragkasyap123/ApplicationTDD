using NUnit.Framework;
using OperatingSystems;
using Assert = NUnit.Framework.Assert;

namespace OperatingSystemTests
{
    [TestFixture]
    class ClientTests
    {
        [SetUp]
        public void SetUp()
        {
            _client = Client.GetInstance;
        }

        [TearDown]
        public void TestTearDown()
        {
            _client = null;

        }

        #region Tests

        [TestCase("ANDROID", Messages.Android)]
        [TestCase("IOS", Messages.Ios)]
        [TestCase("WINDOWS", Messages.Windows)]
        public void GetResult_UpperCaseInput_ExpectedOpTest(string type, string expectedOp)
        {
            AssertPositiveCaseTestResult(type, expectedOp);

        }

        [TestCase("AnDROiD", Messages.Android)]
        [TestCase("Ios", Messages.Ios)]
        [TestCase("WiNDoWS", Messages.Windows)]
        public void GetResult_MixedCaseInput_ExpectedOpTest(string type, string expectedOp)
        {
            AssertPositiveCaseTestResult(type, expectedOp);
        }

        [TestCase("WIN", "")]
        [TestCase("Ois", "")]
        public void GetResult_WrongCaseInput_ExpectedOpTest(string type, string expectedOp)
        {
            AssertPositiveCaseTestResult(type, expectedOp);
        }

        #endregion

        #region private methods

        private void AssertPositiveCaseTestResult(string type, string expectedOp)
        {
            var op = _client.GetResult(type);
            Assert.IsNotNull(op);
            Assert.That(op.Equals(expectedOp));
        }

        #endregion

        #region private members

        private Client _client;

        #endregion

    }
}
