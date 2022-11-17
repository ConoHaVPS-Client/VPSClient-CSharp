namespace ConohaVPS.Commands;

using System.CommandLine;
using System.Threading.Tasks;

internal class BaseCommand
{
    private const string _rootDescripton = "Client for ConoHa VPS.";
    public RootCommand _rootCommand;
    public BaseCommand()
    {
        _rootCommand = new RootCommand(_rootDescripton);
    }

    public async Task<int> Execute(string[] args)
    {
        _rootCommand.SetHandler(() =>
        {
        });

        return await _rootCommand.InvokeAsync(args);
    }
}
