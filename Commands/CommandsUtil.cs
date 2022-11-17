using System.CommandLine;
using System.Diagnostics;

namespace ConohaVPS.Commands;

internal static class CommandsUtil
{
    /// <summary>
    /// 文字列を引数に取るオプションを定義する。
    /// </summary>
    /// <param name="name">オプションのフルネーム</param>
    /// <param name="alias">オプションの別名</param>
    /// <param name="descripton">オプションの説明</param>
    public static Option<string> MakeStringOption(string name, string? alias = null, string? descripton = null)
    {
        var option = new Option<string>(name, descripton);

        if (alias != null)
        {
            option.AddAlias(alias);
        }

        Debug.Assert(option != null);
        return option;
    }

    /// <summary>
    /// 整数を引数に取るオプションを定義する。
    /// </summary>
    /// <param name="name">オプションのフルネーム</param>
    /// <param name="alias">オプションの別名</param>
    /// <param name="descripton">オプションの説明</param>
    public static Option<string> MakeIntegerOption(string name, string? alias = null, string? descripton = null)
    {
        var option = new Option<string>(name, descripton);

        if (alias != null)
        {
            option.AddAlias(alias);
        }

        Debug.Assert(option != null);
        return option;
    }

    /// <summary>
    /// 論理値を引数に取るオプションを定義する。
    /// </summary>
    /// <remarks>明示的に指定されない限り、オプションの値はtrueとなる</remarks>
    /// <param name="name">オプションのフルネーム</param>
    /// <param name="alias">オプションの別名</param>
    /// <param name="descripton">オプションの説明</param>
    public static Option<string> MakeBooleanOption(string name, string? alias = null, string? descripton = null)
    {
        var option = new Option<string>(name, descripton);

        if (alias != null)
        {
            option.AddAlias(alias);
        }

        Debug.Assert(option != null);
        return option;
    }
}
