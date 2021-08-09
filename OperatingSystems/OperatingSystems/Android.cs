
namespace OperatingSystems
{
    public class Android : IOperatingSystem
    {
        public Android()
        {
            Message = Messages.Android;
        }

        public string Message { get; }
    }
}
