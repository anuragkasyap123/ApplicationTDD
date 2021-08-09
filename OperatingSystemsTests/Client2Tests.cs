using NUnit.Framework;
using OperatingSystems;
using Rhino.Mocks;
using Assert = NUnit.Framework.Assert;

namespace OperatingSystemsTests
{
    [TestFixture]
    class Client2Tests
    {
        [SetUp]
        public void SetUp()
        {
            _factory = MockRepository.GenerateMock<IFactory>();
        }

        [TearDown]
        public void TestTearDown()
        {
            _factory = null;
            _client = null;

        }

        #region Tests

        [TestCase("ANDROID", Messages.Android)]
        [TestCase("AnDROiD", Messages.Android)]
        public void GetResult_AndroidInput_ExpectedOpTest(string type, string expectedOp)
        {
            _factory.Expect(x => x.GetOperatingSystem(Arg<string>.Is.Anything)).Return(new Android()).Repeat.Once();
            _client = new Client2(_factory);
            var op = _client.GetResult(type);
            Assert.IsNotNull(op);
            Assert.That(op.Equals(expectedOp));

        }

        [TestCase("IOS", Messages.Ios)]
        [TestCase("Ios", Messages.Ios)]
        public void GetResult_IOSInput_ExpectedOpTest(string type, string expectedOp)
        {
            _factory.Expect(x => x.GetOperatingSystem(Arg<string>.Is.Anything)).Return(new IOS()).Repeat.Once();
            _client = new Client2(_factory);
            var op = _client.GetResult(type);
            Assert.IsNotNull(op);
            Assert.That(op.Equals(expectedOp));

        }

        [TestCase("Windows", Messages.Windows)]
        [TestCase("WiNDoWS", Messages.Windows)]
        public void GetResult_WindowsInput_ExpectedOpTest(string type, string expectedOp)
        {
            _factory.Expect(x => x.GetOperatingSystem(Arg<string>.Is.Anything)).Return(new Windows()).Repeat.Once();
            _client = new Client2(_factory);
            var op = _client.GetResult(type);
            Assert.IsNotNull(op);
            Assert.That(op.Equals(expectedOp));

        }

       
        [TestCase("WIN", "")]
        [TestCase("Ois", "")]
        public void GetResult_WrongCaseInput_ExpectedOpTest(string type, string expectedOp)
        {
            _factory.Expect(x => x.GetOperatingSystem(Arg<string>.Is.Anything)).Return(null).Repeat.Once();
            _client = new Client2(_factory);
            var op = _client.GetResult(type);
            Assert.That(op.Equals(expectedOp));
        }

        #endregion

        #region private members

        private Client2 _client;
        private IFactory _factory;


        #endregion

    }
}
