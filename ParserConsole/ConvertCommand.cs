﻿using AnidbExportParser;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserConsole
{
    internal class ConvertCommand
    {
        public Command GetCommand()
        {
            var command = new Command("convert")
            {
                Description = "Convert an AniDB Mylist export to sqlite."
            };

            var inputOption = new Option<FileInfo>("--input")
            {
                IsRequired = true,
                Description = "Path to the AniDB Mylist export file.",
            };
            inputOption.AddAlias("-i");
            command.AddOption(inputOption);

            var outputOption = new Option<FileInfo>("--output")
            {
                IsRequired = true,
                Description = "Path to save the converted database to."
            };
            outputOption.AddAlias("-o");
            command.AddOption(outputOption);

            command.SetHandler<FileInfo, FileInfo>(ConvertHandler,inputOption,outputOption);

            return command;
        }

        private async Task ConvertHandler(FileInfo inputOptionValue, FileInfo outputOptionValue)
        {
            if (outputOptionValue.Exists)
            {
                Console.Error.WriteLine($"Output file {outputOptionValue.FullName} already exists.");
                Environment.Exit(1);
            }

            try
            {
                Console.WriteLine($"Converting {inputOptionValue.FullName} to {outputOptionValue.FullName}.");
                var myList = new MyList();
                await myList.ParseAnidbXml(inputOptionValue.FullName);
                await myList.ExportData(outputOptionValue.FullName);
                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"An error occurred during the convertion process.");
                if (ex.InnerException == null)
                {
                    Console.Error.WriteLine(ex.Message);
                }
                else
                {
                    Console.Error.WriteLine(ex.InnerException.Message);
                }
                Environment.Exit(1);
            }
        }
    }
}
