

namespace OperatingSystems
{
    public class Windows : IOperatingSystem
    {
        public Windows()
        {
            Message = Messages.Windows;
        }

        public string Message { get; }
    }
}
