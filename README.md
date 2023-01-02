# Anidb Export Parser
Parses an anidb xml export and saves it as [LiteDB](https://www.litedb.org/) database.
 

## Howto
- Go to https://anidb.net/user/export and create a new export using format Xml-plain-new
- Extract the downloaded mylist.xml
- Delete the old database
- Run ```dotnet ef migrations add initial --project AnidbExportParser --verbose```