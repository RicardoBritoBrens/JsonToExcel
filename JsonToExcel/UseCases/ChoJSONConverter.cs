using ChoETL;
using JsonToExcel.Helpers;
using System;
using System.IO;

namespace JsonToExcel.JsonToCsv
{
    public class ChoJSONConverter : IJsonToCvsConverter, ICvsToJsonConverter, IFileLoader
    {
        private FileInfo _inputFile;
        private FileInfo _outputFile;

        public void ConvertJsonToCvs(FileInfo inputfile)
        {
            _inputFile = inputfile;
            _outputFile = new FileInfo(Path.Combine(inputfile.Directory.FullName, Constant.CsvOutputFile));

            ConsolePresentation.ShowConvertingMessage();

            try
            {
                using (var reader = new ChoJSONReader(_inputFile.FullName))
                using (var writer = new ChoCSVWriter(_outputFile.FullName).WithFirstLineHeader())
                {
                    writer.Write(reader);
                }
            }
            catch (Exception exception)
            {
                ConsolePresentation.ShowConsoleExceptionAndReadKey(exception);
            }

            ConsolePresentation.ShowConsoleEndMessageAndReadKey(_outputFile.FullName);

            Environment.Exit(0);
        }

        public void ConvertCvsToJson(FileInfo inputFile)
        {
            _inputFile = inputFile;
            _outputFile = new FileInfo(Path.Combine(inputFile.Directory.FullName, Constant.JsonOutputFile));

            ConsolePresentation.ShowConvertingMessage();

            try
            {
                using (var reader = new ChoCSVReader(_inputFile.FullName).WithFirstLineHeader())
                using (var writer = new ChoJSONWriter(_outputFile.FullName))
                {
                    writer.Write(reader);
                }
            }
            catch (Exception exception)
            {
                ConsolePresentation.ShowConsoleExceptionAndReadKey(exception);
            }

            ConsolePresentation.ShowConsoleEndMessageAndReadKey(_outputFile.FullName);
            Environment.Exit(0);
        }

        public FileInfo LoadFileInfoJson(FileInfo fileInfo)
        {
            _inputFile = fileInfo;
            return _inputFile;
        }

        public FileInfo LoadJson(string filePath)
        {
            _inputFile = new FileInfo(filePath);
            return _inputFile;
        }
    }
}