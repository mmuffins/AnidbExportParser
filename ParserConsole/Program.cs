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
            Console.WriteLine("done1!");

            var anidExportPath2 = "C:\\Users\\email_000\\source\\AnidbExportParser\\ParserConsole\\full.xml";
            var exportPath2 = "C:\\Users\\email_000\\source\\AnidbExportParser\\ParserConsole\\exportTest2.db";
            var myList2 = new MyList();
            await myList2.ParseAnidbXml(anidExportPath2);
            await myList2.ExportData(exportPath2);

            Console.WriteLine("done2!");
        }
    }
}