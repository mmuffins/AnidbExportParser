using AnidbExportParser;
using System.CommandLine;

namespace ParserConsole
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            var rootCommand = new RootCommand("AniDB Export Parser.");
            var convertCommand = new ConvertCommand();
            rootCommand.Add(convertCommand.GetCommand());
            return await rootCommand.Parse(args).InvokeAsync();
        }
    }
}