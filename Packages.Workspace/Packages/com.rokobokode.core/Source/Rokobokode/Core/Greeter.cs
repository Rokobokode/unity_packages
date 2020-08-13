namespace Rokobokode.Core
{
    public class Greeter
    {
        private readonly ILogger _logger;

        public Greeter(ILogger logger)
        {
            _logger = logger;
        }

        public void SayHello()
        {
            _logger.Log("Hello");
        }
    }
}
