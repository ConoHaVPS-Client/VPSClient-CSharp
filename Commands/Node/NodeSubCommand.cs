namespace ConohaVPS.Commands.Node;

using System.CommandLine;

internal class NodeSubCommand
{
    private readonly Command _nodeCommand;
    private readonly Option<string> _username;
    private readonly Option<string> _password;
    private readonly Option<string> _tenantid;
    private readonly Option<string> _endpoint;

    /// <summary>
    /// NodeCommandクラスのコンストラクタ。
    /// </summary>
    public NodeSubCommand(RootCommand rootCommand)
    {
        _nodeCommand = new Command("node", "");
        _username = CommandsUtil.MakeStringOption("--username");
        _password = CommandsUtil.MakeStringOption("--password");
        _tenantid = CommandsUtil.MakeStringOption("--tenantid");
        _endpoint = CommandsUtil.MakeStringOption("--endpoint");

        _nodeCommand.AddGlobalOption(_username);
        _nodeCommand.AddGlobalOption(_password);
        _nodeCommand.AddGlobalOption(_tenantid);
        _nodeCommand.AddGlobalOption(_endpoint);

        rootCommand.AddCommand(_nodeCommand);

        RegisterPlanCommands();
    }

    /// <summary>
    /// Computeサーバーで取り扱っている仮想マシンの種類と各種情報を取得するコマンド"plan"を追加する。
    /// </summary>
    private void RegisterPlanCommands()
    {
        var plan_command = new Command("plan", "Get currently available VPS plans");
        _nodeCommand.AddCommand(plan_command);

        var option_verbose = CommandsUtil.MakeBooleanOption("--verbose", "-v");

        //TODO: コマンドの実装をここに登録する 
        plan_command.SetHandler((username, password, tenantid, endpoint, verbose) =>
        {

        }, _username, _password, _tenantid, _endpoint, option_verbose);
    }
}
