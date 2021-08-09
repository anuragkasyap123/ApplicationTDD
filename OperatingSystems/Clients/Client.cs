using System;

namespace OperatingSystems
{
    public sealed class Client 
    {
        private Client() { 
        
        }
        #region public members

        public static Client GetInstance
        {
            get
            {
                lock (Obj)
                {
                    _instance ??= new Client();
                }

                return _instance;
            }
        }

        #endregion


        #region public methods
        public string GetResult(string input)
        {

            if (input == string.Empty) return input;           
            _factory = new Factory();
            _operatingSystem = _factory.GetOperatingSystem(input);
            return _operatingSystem == null ? string.Empty : _operatingSystem.Message;
        } 

        #endregion


        #region private members

        private static readonly Object Obj = new object();
        private static Client _instance;
        private static IOperatingSystem _operatingSystem;
        private static IFactory _factory;

        #endregion
    }
}
