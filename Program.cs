internal class Program
{
    private static Task<int> Main(string[] args)
    {
        return ConohaVPS.Commands.BaseCommand.Execute(args);
    }
}