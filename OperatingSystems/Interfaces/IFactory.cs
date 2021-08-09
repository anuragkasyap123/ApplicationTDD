namespace OperatingSystems
{
    public interface IFactory
    {
        IOperatingSystem GetOperatingSystem(string type);
    }
}
