
namespace OperatingSystems
{
    public class IOS : IOperatingSystem
    {
        public IOS()
        {
            Message = Messages.Ios;
        }

        public string Message { get; }
    }
}
