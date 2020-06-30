using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToExcel.JsonToCsv
{
    //TODO: PENDING TO ADD TEST USING ServiceStack
    public class ServiceStackJsonConverter
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
    }
}