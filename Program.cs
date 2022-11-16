internal class Program
{
    private static Task<int> Main(string[] args)
    {
        return ConohaVPS.Commands.ConohaVPS.Execute(args);
    }
}