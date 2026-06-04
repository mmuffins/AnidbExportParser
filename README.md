# Anidb Export Parser
Parses an anidb xml export and saves it as sqlite database.

## Running
### Export mylist data
- Go to https://anidb.net/user/export and create a new export using format Xml-plain-new
- Extract the downloaded mylist.xml

### Windows
- Publish the project, or download a pre-built binary from github
- Run ParserConsole.exe and follow the instructions.

### Linux
Enable devenv:
```bash
$ devenv shell
```
- Publish the project
- Run the import
```bash
publish/ParserConsole convert --input <mylist.xml> --output "anidbmylist_$(date +%Y-%m-%d).db"
```

Or altenatively:
```bash
dotnet run --project ParserConsole -- convert --input <mylist.xml> --output "anidbmylist_$(date +%Y-%m-%d).db"
```

## Note
Make sure to clear out all files in the Migration folder and run ```dotnet ef migrations add initial --project AnidbExportParser --verbose``` when changing the database layout.