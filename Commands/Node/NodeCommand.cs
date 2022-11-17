namespace ConohaVPS.Commands.Node;

using System.CommandLine;

internal class NodeCommand
{
    private readonly RootCommand _rootCommand;
    private readonly Command _nodeCommand;
    private string _endpoint;

    /// <summary>
    /// NodeCommandクラスのコンストラクタ。
    /// </summary>
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

        var option_username = CommandsUtil.MakeStringOption("--username");
        var option_password = CommandsUtil.MakeStringOption("--password");
        var option_tenantid = CommandsUtil.MakeStringOption("--tenantid");
        var option_verbose = CommandsUtil.MakeBooleanOption("--verbose", "-v");

        //TODO: コマンドの実装をここに登録する 
        plan_command.SetHandler((username, password, verbose) =>
        {

        }, option_username, option_password, option_verbose);
    }
}
