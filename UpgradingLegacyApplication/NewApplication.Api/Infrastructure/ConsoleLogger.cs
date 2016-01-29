namespace NewApplication.Api.Infrastructure
{
    public interface ICustomLogger
    {
        void Log(string input);
    }

    public class ConsoleLogger : ICustomLogger
    {
        public void Log(string input)
        {
            System.Diagnostics.Debug.WriteLine(input);
        }
    }
}