internal class Program
{
    private static Task<int> Main(string[] args)
    {
        var command = new ConohaVPS.Commands.BaseCommand();
        return command.Execute(args);
    }
}