using ChoETL;
using System;
using System.IO;
using System.Threading.Tasks;

namespace JsonToExcel.JsonToCsv
{
    public class ChoJSONConverter
    {
        private FileInfo _inputFile;
        private FileInfo _outputFile;

        public void ConvertJsonToExcel(FileInfo inputfile)
        {
            _inputFile = inputfile;
            _outputFile = new FileInfo($"{inputfile.Directory.FullName}\\output.csv");

            Console.WriteLine("Converting...");
            Task.Delay(5000);

            Console.WriteLine("Converting...");
            Task.Delay(5000);

            Console.WriteLine("Converting...");
            Task.Delay(5000);

            try
            {
                using (var r = new ChoJSONReader(_inputFile.FullName))
                {
                    using (var w = new ChoCSVWriter(_outputFile.FullName).WithFirstLineHeader())
                    {
                        w.Write(r);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error => {ex.Message}");
                Console.ReadKey();
            }

            Console.WriteLine();
            Task.Delay(5000);

            Console.WriteLine();
            Task.Delay(5000);

            Console.WriteLine($"Done... check the path {_outputFile.FullName}");
            Console.WriteLine("\n Press any key to close this window");

            Task.Delay(5000);
            Console.ReadKey();
            Environment.Exit(0);
        }

        public FileInfo LoadFileInfoJson(FileInfo filePath)
        {
            _inputFile = filePath;
            return _inputFile;
        }

        public FileInfo LoadJson(string filePath)
        {
            _inputFile = new FileInfo(filePath);
            return _inputFile;
        }
    }
}