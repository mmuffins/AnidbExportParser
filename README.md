# Anidb Export Parser
Parses an anidb xml export and saves it as [LiteDB](https://www.litedb.org/) database.

## Running
- Go to https://anidb.net/user/export and create a new export using format Xml-plain-new
- Extract the downloaded mylist.xml
- Build the project
- Run ParserConsole.exe and follow the instructions.

## Note
Make sure to clear out all files in the Migration folder and run ```dotnet ef migrations add initial --project AnidbExportParser --verbose``` when changing the database layout.