namespace NewApplication.Api.Infrastructure
{
    public class ConsoleLogger
    {
        public void Log(string input)
        {
            System.Diagnostics.Debug.WriteLine(input);
        }
    }
}