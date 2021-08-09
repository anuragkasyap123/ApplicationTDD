using System;

namespace OperatingSystems
{
    public class Client2 : IClient
    {
        public Client2()
        {
            _factory = new Factory();
        }

        public Client2(IFactory factory)
        {
            _factory = factory;
        }

        #region public methods

        public string GetResult(string input)
        {

            if (input == string.Empty) return input;
            _operatingSystem = _factory.GetOperatingSystem(input);
            return _operatingSystem == null ? string.Empty : _operatingSystem.Message;
        }

        #endregion


        #region private members

        private static IOperatingSystem _operatingSystem;
        private static IFactory _factory;

        #endregion
    }

}
