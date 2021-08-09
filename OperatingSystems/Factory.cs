
namespace OperatingSystems
{
    public class Factory : IFactory
    {
        public IOperatingSystem GetOperatingSystem(string type)
        {
            return type.ToUpper() switch
            {
                "ANDROID" => new Android(),
                "IOS" => new IOS(),
                "WINDOWS" => new Windows(),
                _ => null,
            };
        }
     }
}
