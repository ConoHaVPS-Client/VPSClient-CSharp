namespace ConohaVPS.Commands;

using System.CommandLine;
using System.Threading.Tasks;

internal class ConohaVPS
{
    public static async Task<int> Execute(string[] args)
    {
        var rootCommand = new RootCommand("Client for ConoHa VPS.");

        rootCommand.SetHandler(() =>
        {
        });

        return await rootCommand.InvokeAsync(args);
    }
}
