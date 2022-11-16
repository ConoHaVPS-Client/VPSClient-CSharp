namespace ConohaVPS.Commands.Node;

using System.CommandLine;

internal class NodeCommand
{
    private readonly RootCommand _rootCommand;
    private readonly Command _nodeCommand;
    private string _endpoint;

    public NodeCommand(RootCommand rootCommand, string endpoint)
    {
        _endpoint = endpoint;
        _rootCommand = rootCommand;

        _nodeCommand = new Command("node", "");



        _rootCommand.AddCommand(_nodeCommand);

        RegisterPlanCommands();
    }

    /// <summary>
    /// Computeサーバーで取り扱っている仮想マシンの種類と各種情報を取得するコマンド"plan"を追加する。
    /// </summary>
    private void RegisterPlanCommands()
    {
        var plan_command = new Command("plan", "Get currently available VPS plans");
        _nodeCommand.AddCommand(_rootCommand);

        var option_token = new Option<string>("--token", "");
        option_token.AddAlias("-t");
        plan_command.AddOption(option_token);

        var option_verbose = new Option<bool>("--verbose", "");
        option_verbose.AddAlias("-v");
        plan_command.AddOption(option_verbose);

        //TODO: コマンドの実装をここに登録する 
        plan_command.SetHandler((token, verbose) =>
        {

        }, option_verbose, option_verbose);
    }
}
