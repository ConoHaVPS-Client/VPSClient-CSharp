using System.CommandLine;
using System.Diagnostics;

namespace ConohaVPS.Commands;

internal static class CommandsUtil
{
    /// <summary>
    /// 整数を引数に取るオプションをサブコマンドに追加。
    /// </summary>
    /// <param name="command">サブコマンドのインスタンス</param>
    /// <param name="option_name">オプションのフルネーム</param>
    /// <param name="option_alias">オプションの別名</param>
    /// <param name="option_descripton">オプションの説明</param>
    public static Option<int> AddIntegerOption(Command command, string option_name, string? option_alias = null, string? option_descripton = null)
    {
        var option = new Option<int>(option_name, option_descripton);

        if (option_alias != null)
        {
            option.AddAlias(option_alias);
        }

        command.AddOption(option);

        Debug.Assert(option != null);
        return option;
    }

    /// <summary>
    /// 文字列を引数に取るオプションをサブコマンドに追加。
    /// </summary>
    /// <param name="command">サブコマンドのインスタンス</param>
    /// <param name="option_name">オプションのフルネーム</param>
    /// <param name="option_alias">オプションの別名</param>
    /// <param name="option_descripton">オプションの説明</param>
    public static Option<string> AddStringOption(Command command, string option_name, string? option_alias = null, string? option_descripton = null)
    {
        var option = new Option<string>(option_name, option_descripton);

        if (option_alias != null)
        {
            option.AddAlias(option_alias);
        }

        command.AddOption(option);

        Debug.Assert(option != null);
        return option;
    }

    /// <summary>
    /// ブール値を引数に取るオプションをサブコマンドに追加。
    /// </summary>
    /// <remarks>明示的に指定されない限り、オプションの値はtrueとなっている</remarks>
    /// <param name="command">サブコマンドのインスタンス</param>
    /// <param name="option_name">オプションのフルネーム</param>
    /// <param name="option_alias">オプションの別名</param>
    /// <param name="option_descripton">オプションの説明</param>
    public static Option<bool> AddBoolOption(Command command, string option_name, string? option_alias = null, string? option_descripton = null)
    {
        var option = new Option<bool>(option_name, option_descripton);

        if (option_alias != null)
        {
            option.AddAlias(option_alias);
        }

        command.AddOption(option);

        Debug.Assert(option != null);
        return option;
    }
}
