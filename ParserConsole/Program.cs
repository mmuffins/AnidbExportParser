using AnidbExportParser;


namespace ParserConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var anidExportPath = "C:\\Users\\email_000\\source\\AnidbExportParser\\ParserConsole\\test1.xml";
            //var anidExportPath = "C:\\Users\\email_000\\source\\AnidbExportParser\\ParserConsole\\test2.xml";
            var anidExportPath = "C:\\Users\\email_000\\source\\AnidbExportParser\\ParserConsole\\full.xml";
            var exportPath = "C:\\Users\\email_000\\source\\AnidbExportParser\\ParserConsole\\exportTest1.db";

            
            var myList = new MyList();
            await myList.ParseAnidbXml(anidExportPath);

            await myList.ExportData(exportPath);

            Console.WriteLine("done!");
        }
    }
}