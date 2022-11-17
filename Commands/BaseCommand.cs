namespace ConohaVPS.Commands;

using System.CommandLine;
using System.Threading.Tasks;

internal class BaseCommand
{
    private const string _rootDescripton = "Client for ConoHa VPS.";

    public async Task<int> Execute(string[] args)
    {
        var rootCommand = new RootCommand(_rootDescripton);

        rootCommand.SetHandler(() =>
        {
        });

        return await rootCommand.InvokeAsync(args);
    }
}
